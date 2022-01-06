using DynamicTechMVC.Data;
using DynamicTechMVC.Entities;
using DynamicTechMVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicTechMVC.Controllers
{
    public class UserAuthController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ApplicationDbContext _context;
        public UserAuthController(ApplicationDbContext context, 
                                  UserManager<ApplicationUser> userManager, 
                                  SignInManager<ApplicationUser> signInManager)
        {
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
        }
        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            loginModel.LoginInvalid = "true";

            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(loginModel.Email,
                                                                     loginModel.Password,
                                                                     loginModel.RememberMe,
                                                                     lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    loginModel.LoginInvalid = "";
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt");
                }

            }
            return PartialView("_UserLoginPartial", loginModel);

        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout(string returnUrl = null)
        {
            await _signInManager.SignOutAsync();

            if (returnUrl != null)
            {
                return LocalRedirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }
        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegisterUser(RegistrationModel registrationModel)
        {
            registrationModel.RegistrationInvalid = "true";

            if (ModelState.IsValid)
            {
                ApplicationUser user = new ApplicationUser
                {
                    UserName = registrationModel.Email,
                    Email = registrationModel.Email,
                    PhoneNumber = registrationModel.PhoneNumber,
                    FirstName = registrationModel.FirstName,
                    LastName = registrationModel.LastName,
                    Address = registrationModel.Address
                };
                var result = await _userManager.CreateAsync(user, registrationModel.Password);
                if (result.Succeeded)
                {
                    registrationModel.RegistrationInvalid = "";

                    await _signInManager.SignInAsync(user, isPersistent: false);
                    if (registrationModel.CategoryId != 0)
                    {
                        await AddCategoryToUser(user.Id, registrationModel.CategoryId);
                    }
                    return PartialView("_UserRegistrationPartial", registrationModel);
                }
                AddErrorsToModelState(result);
                //ModelState.AddModelError("", "Registration attempt fail");
                //var error = ModelState.Select(x => x.Value.Errors).Where(y => y.Count > 0).ToList();
            }
            return PartialView("_UserRegistrationPartial", registrationModel);
        }
        [AllowAnonymous]
        public async Task<bool> UserNameExist(string userName)
        {
            bool userNameExists= await _context.Users.AnyAsync(u => u.UserName.ToUpper() == userName.ToUpper());
            if (userNameExists)
                return true;
            return false;
        }
         private void AddErrorsToModelState(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }
        private async Task AddCategoryToUser(string userId, int categoryId)
        {
            UserCategory userCategory = new UserCategory();
            userCategory.CategoryId = categoryId;
            userCategory.UserId = userId;
            _context.UserCategory.Add(userCategory);
            await _context.SaveChangesAsync();
        }
    }
}
