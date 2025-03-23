using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace TaskManager.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }

        // Navigation property
        public ICollection<Task> Tasks { get; set; }
    }
}
