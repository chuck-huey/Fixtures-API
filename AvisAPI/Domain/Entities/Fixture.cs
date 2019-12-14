using System;
using System.ComponentModel.DataAnnotations.Schema;
using AvisAPI.Domain.Contracts;
using AvisAPI.Domain.Entities;

namespace AvisAPI.Domain.Models
{
    public class Fixture : IEntity
    {
        public Guid Id { get; set; }
        public string Referee { get; set; }
        public int HomeGoals { get; set; }
        public int AwayGoals { get; set; }
        public string Stadium { get; set; }
        public EMatchStatus Status { get; set; } = EMatchStatus.Pending;
        public DateTimeOffset MatchDate { get; set; }

        public Guid HomeTeamId { get; set; }
        public Guid AwayTeamId { get; set; }

        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }

        [ForeignKey("HomeTeamId")]
        public virtual Team HomeTeam { get; set; }

        [ForeignKey("AwayTeamId")]
        public virtual Team AwayTeam { get; set; }
    }
}
