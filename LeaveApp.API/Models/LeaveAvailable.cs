namespace LeaveApp.API.Models
{
    public class LeaveAvailable
    {
        public int Id { get; set; }
        public int AvailableNumberOfDays { get; set; }
        public string LeaveType { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
    }
}