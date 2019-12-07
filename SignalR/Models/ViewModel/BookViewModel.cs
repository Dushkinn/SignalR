


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR.Models.ViewModel
{
    public class BookViewModel
    {
        public Guid ID { get; set; }
        public String Name { get; set; }
        public String Discription { get; set; }
        public Guid selectedBookType { get; set; }
        public Guid selectedLanguage { get; set; }
        

    }
}
