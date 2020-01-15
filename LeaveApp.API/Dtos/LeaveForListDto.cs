using System;

namespace LeaveApp.API.Dtos
{
    public class LeaveForListDto
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TotalNumberOfDays { get; set; }
        public string LeaveType { get; set; }
        public string Reason { get; set; }
        public string Status { get; set; }
        public int Manager { get; set; }
        public int HR { get; set; }

        public int CreatedBy { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime UpdatedDate { get; set; }

        public int UserId { get; set; }
    }
}