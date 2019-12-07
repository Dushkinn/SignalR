using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SignalR.Models
{
    public class UserRole
    {
        [Key]
        public Guid Role { get; set; }
        public String Name { get; set; }
        
    }
}