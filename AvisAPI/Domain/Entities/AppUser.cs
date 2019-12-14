using System;
using AvisAPI.Domain.Contracts;
using Microsoft.AspNetCore.Identity;

namespace AvisAPI.Domain.Entities
{
    public class AppUser : IdentityUser, IEntity
    {
        public string Name { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
    }
}
