using System;
using System.Collections.Generic;

namespace PBL3_FLy.Data;

public partial class Airport
{
    public int AirportId { get; set; }

    public string? AirportName { get; set; }

    public string? City { get; set; }

    public virtual ICollection<Flight> FlightArrivalAirports { get; set; } = new List<Flight>();

    public virtual ICollection<Flight> FlightDepartAirports { get; set; } = new List<Flight>();
}
