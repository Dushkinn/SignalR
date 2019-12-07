using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR.Models.ViewModel
{
    public class BookItemViewModel
    {
        public Guid ID { get; set; }
        public StateType State { get; set; }
        public Guid selectedState { get; set; }
        [Display(Name = "Book Name")]
        public Book Book { get; set; }
        public Guid selectedBook { get; set; }
    }
}
