using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SignalR.Models
{
    public class User : IdentityUser
    {
        
        [CustomValidation.UserName(ErrorMessage = "First charecters is lower  ")]
        public String FullName { get; set; }
        public String Password { get; set; }
        public UserRole Role { get; set; }

    }
}