namespace TaskManagementSystem.Models
{
    public class SystemLog
    {
        public int SystemLogId { get; set; }
        public int UserId { get; set; }
        public string Action { get; set; }
        public string ResourceType { get; set; }
        public string ResourceId { get; set; }
        public string Details { get; set; }
        public string IpAddress { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
