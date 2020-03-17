using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class DatabaseController : Controller
    {
        static List<DEPTDATA> list=null;
        static List<EMPDATA> listemp = null;
        // GET: Database
        public ActionResult Index()
        {

            EMPDATA e = new EMPDATA();



            return View(e);
        }

        [HttpPost]
        public ActionResult Index(EMPDATA e)
        {
            ViewBag.msg=DBoperations.InsertEMPDATA(e);
            return View();
        }

        public ActionResult getDeptData()
        {
            return View();
        }
        public ActionResult Getdept()
        {
            int deptno = int.Parse(Request.Form["txtdeptno"]);
          List<EMPDATA> l=  DBoperations.Getdept(deptno);
          
            return View("getDeptData",l);

        }
        public ActionResult getDepts()
        {
            list = DBoperations.getDepts();
            ViewBag.l = list;
            return View();
        }
        public ActionResult showdata()
        {
            int deptno = int.Parse(Request.QueryString["d"]);
            ViewBag.l = list;
            List<EMPDATA> l=DBoperations.Getdept(deptno);
            return View("getDepts",l);
        }
        public ActionResult deletedata()
        {
            listemp = DBoperations.delemp();
            ViewBag.e = listemp;
            return View();
          
           
        }
        public ActionResult del()
        {
            int empno = int.Parse(Request.Form["ddlempno"]);
           
            ViewBag.res = DBoperations.empno_del(empno);
            ViewBag.e = DBoperations.delemp(); 

            return View("deletedata");
        }
        public ActionResult update()
        {
            return View();
        }
        public ActionResult empupdate()
        {
            int empno = int.Parse(Request.QueryString["e"]);
            EMPDATA emp=DBoperations.extractemp(empno);
            return View("update",emp);
        }
        public ActionResult updatebtn(EMPDATA e)
        {
            int empno = int.Parse(Request.Form["EMPNO"]);
            string s = DBoperations.updatedata(empno, e);
            ViewBag.msg = s;


            return View("update");
        }
        
    }
}