using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DemoMVC.Models
{
   
    public class DBoperations
    {
       

       
            static DemoEntities d = new DemoEntities();
           
        
        public static string InsertEMPDATA(EMPDATA a)
        {
            try
            {
                d.EMPDATAs.Add(a);
                d.SaveChanges();
            }
            catch(DbUpdateException d)
            {
                SqlException ex = d.GetBaseException() as SqlException;
                if(ex.Message.Contains("EMP_PK"))
                {
                    return "same empno cant be added";
                }
                if(ex.Message.Contains("FK__EMPDATA__DEPTNO__236943A5"))
                {
                    return "no proper dept no";
                }
                
            }
            return "1 Row Inserted";
        }
        public static List<EMPDATA> Getdept(int deptno)
        {
            var le = from l in d.EMPDATAs
                     where l.DEPTNO == deptno
                     select l;
            return le.ToList();


        }

        public static List<DEPTDATA> getDepts()
        {
            var le = from l in d.DEPTDATAs
                     select l;
            return le.ToList();
        }

       public static List<EMPDATA> delemp()
        {
            var le = from l in d.EMPDATAs
                     select l;
            return le.ToList();
        }

        public static string empno_del(int empno)
        {
            var le = (from l in d.EMPDATAs
                     where l.EMPNO == empno
                     select l).FirstOrDefault();
            d.EMPDATAs.Remove(le);
            d.SaveChanges();
            return "successful deletion";



        }

        public static EMPDATA extractemp(int empno)
        {
            var le = from l in d.EMPDATAs
                     where l.EMPNO == empno
                     select l;


            return le.FirstOrDefault();



        }

        public static string updatedata(int empno,EMPDATA emp)
        {
            var le = from l in d.EMPDATAs
                     where l.EMPNO == empno
                     select l;

            foreach(var item in le)
            {
                item.JOB = emp.JOB;
                item.MGR = emp.MGR;
                item.SAL = emp.SAL;
                item.COMM = emp.COMM;
                item.DEPTNO = emp.DEPTNO;


            }

            d.SaveChanges();
            return "updation done successfully";
        }
        public static List<EMPDATA> Empdate(DateTime start,DateTime end)
        {
            var le = from e in d.EMPDATAs
                     where e.HIREDATE > start && e.HIREDATE < end
                     select e;
            return le.ToList();

        }
        public static List<EMPDATA> emptable()
        {

            var le = from e in d.EMPDATAs
                     select e;
            return le.ToList();
        }
        public static EMPDATA empemp(int empno)
        {
            var le = (from e in d.EMPDATAs
                     where e.EMPNO == empno
                     select e);
            return le.First();

        }
    }
}