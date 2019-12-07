using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SignalR.Models
{
    public class ReservationBook
    {
        [Key]
        public Guid ID { get; set; }
       public User User { get; set; }
       public BookItem BookItem { get; set; }  
    }
}