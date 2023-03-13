using MVCNorthwind_1.DesignPatterns.SingletonPattern;
using MVCNorthwind_1.Models;
using MVCNorthwind_1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCNorthwind_1.Controllers
{
    public class CategoryController : Controller
    {
        NorthwindEntities _db;

        public CategoryController()
        {
            _db = DBTool.DbInstance;
        }
        public ActionResult ListCategories()
        {
            List<CategoryVM> categories = _db.Categories.Select(x => new CategoryVM
            {
                ID = x.CategoryID,
                CategoryName = x.CategoryName,
                Description = x.Description,
            }).ToList();
            
            return View(categories);
        }

        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(CategoryVM cvm)
        {
            Category c = new Category
            {
                CategoryName = cvm.CategoryName,
                Description = cvm.Description
            };
            _db.Categories.Add(c);
            _db.SaveChanges();

            return RedirectToAction("ListCategories");
        }
            
    }
}