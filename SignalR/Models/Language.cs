using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SignalR.Models
{
    public class Language
    {
        [Key]
        public Guid ID { get; set; }
        [Display(Name = "Language Name")]
        [Required]
        [StringLength(100)]
        public String LanguageName { get; set; }
    }
}