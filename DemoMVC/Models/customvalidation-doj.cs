using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoMVC.Models
{
    public class customvalidation_doj:ValidationAttribute
    {
        //public override bool IsValid(object value)
        //{
        //    DateTime d = Convert.ToDateTime(value);
        //    return d<= DateTime.Now;


        //}

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            DateTime d = Convert.ToDateTime(value);
                   DateTime today = DateTime.Today;
                  TimeSpan t = today.Subtract(d);
                 int age = (int)(t.TotalDays / 365);

            if (d > today)
                return new ValidationResult("date cannot be greater than today's date");
            else if (age < 21 || age > 58)
                return new ValidationResult("age must be between 21 to 58 ");
            else
                return ValidationResult.Success;


        }






    }
    //public class customage:ValidationAttribute
    //{
    //    public override bool IsValid(object value)
    //    {
    //        DateTime d = Convert.ToDateTime(value);
    //        DateTime today = DateTime.Today;
    //        TimeSpan t = today.Subtract(d);
    //        int age = (int)(t.TotalDays / 365);
    //        if(age>21 && age<58)
    //        {
    //            return true;
    //        }
    //        else
    //        {
    //            return false;
    //        }
            
    //    }
    //}
}