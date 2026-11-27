using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketHub.Domain.Common;

namespace TicketHub.Domain.Entities
{
    public class Category : BaseEntity
    {
        public required string Name { get; set; }

        public string? Description { get; set; }

        public ICollection<Event> Events { get; set; } = [];
    }
}