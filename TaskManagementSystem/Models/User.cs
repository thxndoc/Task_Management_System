﻿namespace TaskManagementSystem.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string RoleId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Status { get; set; }
        public string CreatedDate { get; set; }
    }
}
