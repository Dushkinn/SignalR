using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR.Models.ViewModel
{
    public class UserViewModel
    {
        public Guid ID { get; set; }
        [CustomValidation.UserName(ErrorMessage = "First charecters is lower  ")]
        public String FullName { get; set; }
        public String Password { get; set; }
        public UserRole UserRole { get; set; }
        public Guid selectedRole { get; set; }
    }
}
