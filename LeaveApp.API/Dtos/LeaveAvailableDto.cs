namespace LeaveApp.API.Dtos
{
    public class LeaveAvailableDto
    {
        public int Id { get; set; }
        public int AvailableNumberOfDays { get; set; }
        public string LeaveType { get; set; }
        public int UserId { get; set; }
    }
}