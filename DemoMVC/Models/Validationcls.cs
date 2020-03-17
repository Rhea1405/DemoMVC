using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoMVC.Models
{
    public class Validationcls
    {
        string firstname;
        string lastname;
        double salary;
        string pancard;
        string password;
        string confirmpass;
        string phone;
        string email;
        DateTime doj;

        [Required(ErrorMessage ="first name is required")]
        [StringLength(maximumLength:25,ErrorMessage ="max length is 25 only")]
        public string Firstname { get => firstname; set => firstname = value; }
        [Required(ErrorMessage ="last name is required")]
        public string Lastname { get => lastname; set => lastname = value; }
        [Required(ErrorMessage ="salary is required")]
        [Range(10000,200000,ErrorMessage ="salary should be between 10000 and 2lacs")]
        public double Salary { get => salary; set => salary = value; }
        [Required(ErrorMessage ="pancard is must")]
        [RegularExpression("^[A-Z]{5}[0-9]{4}[A-Z]$",ErrorMessage ="invalid pan number")]
        public string Pancard { get => pancard; set => pancard = value; }
        [Required(ErrorMessage ="required")]
        [DataType(DataType.Password)]
        
        public string Password { get => password; set => password = value; }
        [Required(ErrorMessage = "required")]
        [Compare("Password",ErrorMessage ="do not match")]
        public string Confirmpass { get => confirmpass; set => confirmpass = value; }
        [Phone(ErrorMessage ="invalid phone")]
        [MinLength(10,ErrorMessage ="10 digits only")]
        [MaxLength(10,ErrorMessage ="10 digits only")]
        public string Phone { get => phone; set => phone = value; }
        [Required(ErrorMessage = "required")]
        [EmailAddress(ErrorMessage ="invalid")]

        public string Email { get => email; set => email = value; }


        [customvalidation_doj(ErrorMessage ="date")]
        
        public DateTime Doj { get => doj; set => doj = value; }
    }
}