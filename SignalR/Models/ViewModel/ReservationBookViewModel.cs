using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR.Models.ViewModel
{
    public class ReservationBookViewModel
    {
        public Guid ID { get; set; }
        public User User { get; set; }
        public Guid selectedUser { get; set; }
        public BookItem BookItem { get; set; }
        public Guid selectedBookItem { get; set; }
    }
}
