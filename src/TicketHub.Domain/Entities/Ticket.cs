using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketHub.Domain.Common;
using TicketHub.Domain.Enums;

namespace TicketHub.Domain.Entities
{
    public class Ticket : BaseEntity
    {
        public required string Code { get; set; }

        public TicketStatus Status { get; set; } = TicketStatus.Valid;

        public DateTime PurchasedAt { get; set; } = DateTime.UtcNow;

        public Guid TicketTypeId { get; set; }

        public TicketType? TicketType { get; set; }

        public required string BuyerId { get; set; }
    }
}