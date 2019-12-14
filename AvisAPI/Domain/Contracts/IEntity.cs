using System;
namespace AvisAPI.Domain.Contracts
{
    public interface IEntity
    {
        DateTimeOffset CreatedAt { get; set; }
        DateTimeOffset UpdatedAt { get; set; }
    }
}
