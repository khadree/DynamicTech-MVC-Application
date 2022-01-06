using DynamicTechMVC.Data;
using DynamicTechMVC.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicTechMVC.Controllers
{
    public class ContentController : Controller
    {
        private readonly ApplicationDbContext _context;
        private int categoryItemId;

        public ContentController(ApplicationDbContext  context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            Content content = await (from item in _context.Content
                                     where item.CategoryItem.Id == categoryItemId
                                     select new Content
                                     {
                                         Title = item.Title,
                                         VideoLink = item.VideoLink,
                                         HTMLContent = item.HTMLContent
                                     }).FirstOrDefaultAsync();

            return View(content);
        }
    }
}
