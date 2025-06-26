namespace TaskManagementSystem.Models
{
    public class TaskHistory
    {
        public int HistoryId { get; set; }
        public int TaskId { get; set; }
        public int ChangedByUserId { get; set; }
        public string FieldChanged { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public DateTime ChangeDate { get; set; }
        public string ChangeType { get; set; }
    }
}
