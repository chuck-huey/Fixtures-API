using System;
using Microsoft.AspNetCore.Identity;

namespace AvisAPI.Domain.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
