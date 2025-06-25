namespace TaskManagementSystem.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string CreatedBy { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public DateOnly CreatedDate { get; set; }
    }
}
