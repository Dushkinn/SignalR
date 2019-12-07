using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SignalR.Models
{
    public class BookType
    {
        [Key]
        public Guid ID { get; set; }
        [Display(Name = "Book Type Discription")]
        [Required]
        [StringLength(100)]
        public String Discription { get; set; }
        
    }
}