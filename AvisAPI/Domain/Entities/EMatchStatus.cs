using System;

namespace AvisAPI.Domain.Entities
{
    public enum EMatchStatus : byte
    {
        Pending,
        Ongoing,
        Completed,
        Cancelled
    }
}
