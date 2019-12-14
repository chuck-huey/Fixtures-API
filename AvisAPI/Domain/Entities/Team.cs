using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AvisAPI.Domain.Contracts;
using AvisAPI.Domain.Models;

namespace AvisAPI.Domain.Entities
{
    public class Team : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Coach { get; set; }
        public string Stadium { get; set; }
        public int StadiumCapacity { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }

        [InverseProperty(nameof(Fixture.HomeTeam))]
        public virtual List<Fixture> HomeMatches { get; set; } = new List<Fixture>();

        [InverseProperty(nameof(Fixture.AwayTeam))]
        public virtual List<Fixture> AwayMatches { get; set; } = new List<Fixture>();
    }
}
