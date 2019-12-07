using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SignalR.Models
{
    public class BookReservationRequest
    {
        [Key]
        public Guid ID { get; set; }
        public Book Book { get; set; }
        public User User { get; set;  }
        public DateTime ReservationDate { get; set; }

    }
}