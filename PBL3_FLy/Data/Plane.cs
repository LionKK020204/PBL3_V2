using System;
using System.Collections.Generic;

namespace PBL3_FLy.Data;

public partial class Plane
{
    public int PlaneId { get; set; }

    public string? Model { get; set; }

    public int? BusinessSeatNum { get; set; }

    public int? EconomySeatNum { get; set; }

    public string? AirlineName { get; set; }

    public virtual ICollection<Flight> Flights { get; set; } = new List<Flight>();
}
