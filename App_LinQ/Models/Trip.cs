using System;
using System.Collections.Generic;

namespace App_LinQ.Models;

public partial class Trip
{
    public int TripId { get; set; }

    public string? TripDestination { get; set; }

    public DateOnly? TripDate { get; set; }

    public decimal? TripPrice { get; set; }

    public int? SeatsAvailable { get; set; }
}
