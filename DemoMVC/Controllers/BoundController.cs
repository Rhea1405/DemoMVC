using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class BoundController : Controller
    {
        // GET: Bound
        public ActionResult Index()
        {


            Emp e = new Emp();
            return View(e);
        }
        public ActionResult display(Emp A)
        {



            return View(A);
        }
        public ActionResult Index1()
        {


            Emp e = new Emp();
            return View(e);
        }
        [HttpPost]
        public ActionResult Index1(Emp a)
        {
            return View("Display",a);
        }
        public ActionResult Unbound()
        {
            return View();

        }
        public ActionResult showdata()
        {
            Emp e = new Emp();
            e.Empno = int.Parse(Request.Form["txtempno"]);
            e.Ename = Request.Form["txtename"];
            e.Sal = double.Parse(Request.Form["txtsal"]);
            return View(e);
        }
    }
}