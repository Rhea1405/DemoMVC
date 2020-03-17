using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    
    public class DateController : Controller
    {
        // GET: Date
        static List<EMPDATA> l=null;
        public ActionResult DateView()
        {
            return View();
        }
        public ActionResult extractdate()
        {

            DateTime start = DateTime.Parse(Request.Form["txtsd"]);
            DateTime end = DateTime.Parse(Request.Form["txted"]);
           l= DBoperations.Empdate(start, end);
            ViewBag.list = l;

            return View("DateView");
        }




    }
}