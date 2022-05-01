using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication9.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        ContactManager cm = new ContactManager();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult SendMassage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SendMassage(Contact p)
        {
            cm.BLContactAdd(p);
            return View();
        }
    }
}