using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketHub.Domain.Common;

namespace TicketHub.Domain.Entities
{
    public class Venue : BaseEntity
    {
        public required string Name { get; set; }
        public required string Address { get; set; }
        public required string City { get; set; }

        public required int Capacity { get; set; }

        public ICollection<Event> Events { get; set; } = [];

    }
}