namespace TaskManagementSystem.Models
{
    public class TaskAssignment
    {
        public int TaskAssignmentId { get; set; }
        public int TaskId { get; set; }
        public int UserId { get; set; }
        public DateTime AssignedDate { get; set; }
        public DateTime CompletedDate { get; set; }
        public string Notes { get; set; }
        public bool isActive { get; set; } = true;
    }
}
