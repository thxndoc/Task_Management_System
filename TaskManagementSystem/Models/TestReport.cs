namespace TaskManagementSystem.Models
{
    public class TestReport
    {
        public int TestReportId { get; set; }
        public int BugId { get; set; }
        public string GeneratedBy { get; set; }
        public DateOnly ReportDate { get; set; }
        public string Details { get; set; }
    }
}
