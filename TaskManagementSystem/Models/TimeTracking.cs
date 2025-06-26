namespace TaskManagementSystem.Models
{
    public class TimeTracking
    {
        public int TimeTrackingId { get; set; }
        public int TaskId { get; set; }
        public int UserId { get; set; }
        public decimal HoursWorked { get; set; }
        public DateTime WorkDate { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
