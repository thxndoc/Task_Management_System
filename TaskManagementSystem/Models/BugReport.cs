namespace TaskManagementSystem.Models
{
    public class BugReport
    {
        public int BugId { get; set; }
        public int TaskId { get; set; }
        public string ReportedBy { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateOnly ReportedDate { get; set; }
    }
}
