using DynamicTechMVC.Data;
using DynamicTechMVC.Entities;
using DynamicTechMVC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicTechMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context,SignInManager<ApplicationUser > signInManager, UserManager<ApplicationUser> userManager )
        {
            _logger = logger;
            _signInManager = signInManager;
            _userManager = userManager;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<CategoryItemDetailModel> categoryItemDetailModels = null;
            IEnumerable<GroupedCategoryItemsByCategoryModel> groupedCategoryItemsByCategoryModels = null;

            CategoryDetailsModel categoryDetailsModel = new CategoryDetailsModel();

            if (_signInManager.IsSignedIn(User))
            {
                var user = await _userManager.GetUserAsync(User);

                if (user != null)
                {
                    categoryItemDetailModels = await GetCategoryItemDetailsForUser(user.Id);
                    groupedCategoryItemsByCategoryModels = GetGroupedCategoryItemsByCategory(categoryItemDetailModels);

                    categoryDetailsModel.GroupedCategoryItemsByCategoryModels = groupedCategoryItemsByCategoryModels;

                }

            }
            else
            {
                var categories = await GetCategoriesThatHaveContent();

                categoryDetailsModel.Categories = categories;

            }

            return View(categoryDetailsModel);
        }

        private async Task<List<Category>> GetCategoriesThatHaveContent()
        {
            var categoriesWithContent = await (from category in _context.Category
                                               join categoryItem in _context.CategoryItem
                                               on category.Id equals categoryItem.CategoryId
                                               join content in _context.Content
                                               on categoryItem.Id equals content.CategoryItem.Id
                                               select new Category
                                               {
                                                   Id = category.Id,
                                                   Title = category.Title,
                                                   Description = category.Description,
                                                   ThumbnailImagePath = category.ThumbnailImagePath
                                               }).Distinct().ToListAsync();
            return categoriesWithContent;

        }

        private IEnumerable<GroupedCategoryItemsByCategoryModel> GetGroupedCategoryItemsByCategory(IEnumerable<CategoryItemDetailModel> categoryItemDetailsModels)
        {
            return from item in categoryItemDetailsModels
                   group item by item.CategoryId into g
                   select new GroupedCategoryItemsByCategoryModel
                   {
                       Id = g.Key,
                       Title = g.Select(c => c.CategoryTitle).FirstOrDefault(),
                       Items = g
                   };
        }

        private async Task<IEnumerable<CategoryItemDetailModel>> GetCategoryItemDetailsForUser(string userId)
        {
            return await (from catItem in _context.CategoryItem
                          join category in _context.Category
                          on catItem.CategoryId equals category.Id
                          join content in _context.Content
                          on catItem.Id equals content.CategoryItem.Id
                          join userCat in _context.UserCategory
                          on category.Id equals userCat.CategoryId
                          join mediaType in _context.MediaType
                          on catItem.MediaTypeId equals mediaType.Id
                          where userCat.UserId == userId
                          select new CategoryItemDetailModel
                          {
                              CategoryId = category.Id,
                              CategoryTitle = category.Title,
                              CategoryItemId = catItem.Id,
                              CategoryItemTitle = catItem.Title,
                              CategoryItemDescription = catItem.Description,
                              MediaImagePath = mediaType.ThumbnailImagePath
                          }).ToListAsync();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
