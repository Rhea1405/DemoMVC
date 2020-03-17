using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public ActionResult Index() //whenever we want to move from controller to view,the return type should always be actionresult
        {
            ViewBag.str="my first mvc project";
            ViewData["str1"] = "my first mvc by using viewdata";
            TempData["str2"] = "my first with tempdata";
            return View(); //and we should always return view







        }
        public ActionResult Sendobject()
        {
            Emp e = new Emp();
            e.Empno = 1;
            e.Ename = "rajesh";
            e.Sal = 8700;



            return View(e);
        }
        public ActionResult sendmultipleobjects()
        {
            List<Emp> l = new List<Emp>();
            Emp e = null;
             e = new Emp();
            e.Empno = 1;
            e.Ename = "ram";
            e.Sal = 5000;
            l.Add(e); 


            e = new Emp();
            e.Empno = 2;
            e.Ename = "priya";
            e.Sal = 4500;
            l.Add(e);


            return View(l);

        }
        public ActionResult sendobjectviewbag()
        {
            Emp e = null;
            e = new Emp();
            e.Empno = 2;
            e.Ename = "sneha";
            e.Sal = 7000;
            ViewBag.p = e;
            return View();
        }
        public ActionResult sendobjectsusingviewbag()
        {
            List<Emp> l = new List<Emp>();
            Emp e = null;
            e = new Emp();
            e.Empno = 3;
            e.Ename = "sandy";
            e.Sal = 3400;
            l.Add(e);

            e = new Emp();
            e.Empno = 13;
            e.Ename = "andrew";
            e.Sal = 14000;
            l.Add(e);

            ViewBag.xyz = l;
            return View();

        }


    }
}