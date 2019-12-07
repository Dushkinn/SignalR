using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using SignalR.Controllers;
using SignalR.Models;

namespace SignalR.CustomValidation
{
    public class UserNameAttribute : ValidationAttribute
    {


        //protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        //{
        //    ApplicationContext _context = (ApplicationContext)validationContext
        //                 .GetService(typeof(ApplicationContext));
        //    var property = value as string;
        //    User user = _context.Users.Where(c => c.FullName == property).First();

        //    if (user == null)
        //    {
        //        return new ValidationResult("The user already exists");
        //    }

        //    return ValidationResult.Success;
        //}
        public override bool IsValid(object value)
        {
            var property = value as string;
            if (char.IsLower(property[0]))
            {
                return false;
            }

            return true;
        }
    }
}
