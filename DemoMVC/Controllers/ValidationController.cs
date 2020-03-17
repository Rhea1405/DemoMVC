using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class ValidationController : Controller
    {
        // GET: Validation
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult getback(Validationcls v)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("displaypage");
            }

            return View("Index");
        }
        public ActionResult displaypage()
        {


            return View();
        }
    }
}