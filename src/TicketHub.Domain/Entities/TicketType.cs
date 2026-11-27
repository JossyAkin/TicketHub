using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketHub.Domain.Common;

namespace TicketHub.Domain.Entities
{
    public class TicketType : BaseEntity
    {
        public required string Name { get; set; }

        public decimal Price { get; set; }

        public int QuantityAvailable { get; set; }

        public int QuantitySold { get; set; }

        public Guid EventId { get; set; }

        public Event? Event { get; set; }

        public ICollection<Ticket> Tickets { get; set; } = [];

    }
}