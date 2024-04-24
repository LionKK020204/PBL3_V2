using System;
using System.Collections.Generic;

namespace PBL3_FLy.Data;

public partial class Ticket
{
    public int TicketId { get; set; }

    public int UserId { get; set; }

    public int FlightId { get; set; }

    public DateTime CreateDate { get; set; }

    public bool TicketClass { get; set; }

    public int SeatNum { get; set; }

    public int TicketPrice { get; set; }

    public bool? TicketType { get; set; }

    public virtual Flight Flight { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
