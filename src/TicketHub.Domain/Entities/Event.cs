using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketHub.Domain.Common;
using TicketHub.Domain.Enums;

namespace TicketHub.Domain.Entities
{
    public class Event : BaseEntity
    {
        public required string Title { get; set; }

        public string? Description { get; set; }
        public DateTime StartsAt { get; set; }

        public DateTime EndsAt { get; set; }

        public EventStatus Status { get; set; } = EventStatus.Draft;

        public  Guid CategoryId { get; set; }

        public Category? Category { get; set; }

        public Guid VenueId { get; set; }
        public Venue? Venue { get; set; }

        public required string OrganizerId { get; set; }

        public ICollection<TicketType> TicketTypes { get; set; } = [];
    }
}