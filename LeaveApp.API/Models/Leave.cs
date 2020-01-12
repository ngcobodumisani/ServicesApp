using System;

namespace LeaveApp.API.Models
{
    public class Leave
    {
        public int Id { get; set; }
        public DateTime DateAdded { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
    }
}