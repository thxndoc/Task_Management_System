namespace TaskManagementSystem.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        public int UserId { get; set; }
        public string RoleName { get; set; }
        public string ProjectLead { get; set; }
        public string SystemAdmin { get; set; }
        public string Developer { get; set; }
        public string SoftwareTester { get; set; }
    }
}
