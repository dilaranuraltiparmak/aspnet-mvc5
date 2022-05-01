using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication9.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        readonly CategoryManager cm = new CategoryManager();
        public ActionResult Index()
        {
            var categoryvalues = cm.GetAll();
            return View(categoryvalues);
        }
        public PartialViewResult BlogDetailsCategoryList()
        {
            var categoryvalues = cm.GetAll();
            return PartialView(categoryvalues);
        }
    }
}