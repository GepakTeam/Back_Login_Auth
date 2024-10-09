using Microsoft.AspNetCore.Identity;
using System;

namespace Asilo.Models.Account
{
    public class User : IdentityUser<long>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        public bool EmailConfirmed { get; set; }
    }
}
