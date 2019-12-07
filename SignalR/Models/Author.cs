using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SignalR.Models
{
    public class Author
    {
        [Key]
        public Guid Id { get; set; }
        public String FullName { get; set; }
        public DateTime DOB { get; set; }
        public String Biography { get; set; }

    }
}