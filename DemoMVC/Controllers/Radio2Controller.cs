using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class Radio2Controller : Controller
    {
        // GET: Radio2
        List<EMPDATA> l = null;
        public ActionResult Index1()
        {
          l=  DBoperations.emptable();

            ViewBag.emplist = l;

           return View();
        }
        public ActionResult radioextract()
        {
            //l = DBoperations.emptable();
            int empno = Convert.ToInt32(Request.Form["rdb"]);

                       

            return View(DBoperations.empemp(empno));

        }
    }
}