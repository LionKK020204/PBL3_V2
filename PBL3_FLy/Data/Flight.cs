using System;
using System.Collections.Generic;

namespace PBL3_FLy.Data;

public partial class Flight
{
    public int FlightId { get; set; }

    public int PlaneId { get; set; }

    public DateTime FlightTime { get; set; }

    public int DepartAirportId { get; set; }

    public int ArrivalAirportId { get; set; }

    public DateTime? ReturnFlightTime { get; set; }

    public virtual Airport ArrivalAirport { get; set; } = null!;

    public virtual Airport DepartAirport { get; set; } = null!;

    public virtual Plane Plane { get; set; } = null!;

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
