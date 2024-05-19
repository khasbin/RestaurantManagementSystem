﻿using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Restaurant_Management_System.Models
{
    public class UserRole
    {
        public int UserRoleId { get; set; }
        public string RoleName { get; set; }   
        public ICollection<User> Users { get; set; }
    }
}
