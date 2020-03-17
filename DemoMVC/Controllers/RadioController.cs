using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class RadioController : Controller
    {
        // GET: Radio
        List<DEPTDATA> dlist = null;
        List<EMPDATA> l = null;
        public ActionResult Index()
        {
            dlist = DBoperations.getDepts();
            ViewBag.d = dlist;
            return View();
        }
        public ActionResult radiobtn()
        {
            dlist = DBoperations.getDepts();
            ViewBag.d = dlist;


            if (Request.Form["txtsd"]!=null && Request.Form["txted"]!=null)
            {
                DateTime start = DateTime.Parse(Request.Form["txtsd"]);
                DateTime end = DateTime.Parse(Request.Form["txted"]);
                l = DBoperations.Empdate(start, end);
                ViewBag.list = l;
            }
            if(Request.Form["ddldeptno"]!=null)
            {
                int deptno = int.Parse(Request.Form["ddldeptno"]);
                l = DBoperations.Getdept(deptno);
                ViewBag.list = l;
            }
            
           
            
            return View("Index");
        }
    }
}