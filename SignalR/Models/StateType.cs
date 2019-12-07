using System;
using System.ComponentModel.DataAnnotations;

namespace SignalR.Models
{
    public class StateType
    {
        [Key]
        public Guid Id { get; set; }

        public String StateName { get; set; }
    }
}