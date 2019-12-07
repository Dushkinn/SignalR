using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SignalR.Models
{
    public class Tag
    {
        [Key]
        [Display(Name = "ID")]
        public Guid ID { get; set; }
        [Display(Name = "Name")]
        [Required]
        [StringLength(20)]
        public String Name { get; set; }
        [Display(Name = "Discription")]
        [Required]
        [StringLength(100)]
        public String Discription { get; set; }
    }
}