using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace SignalR.Models.ViewModel
{
    public class UserViewModel
    {
        public List<IdentityUser> users { get; set; }

        
    }
}
