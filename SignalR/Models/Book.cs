using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SignalR.Models
{
    public class Book
    {
        [Key]
        public Guid ID { set; get; }
        public String Name { set; get; }
        public String Discription { get; set; }

        public ICollection<Tag> Tags { get; set; }
        public void addTag( Tag tag) {
            Tags.Add(tag);
        }
        public ICollection<Tag> getTags() {
            return this.Tags;
        }
        public BookType BookType { get; set; }
        public Language Language { get; set; }
        
    }
}