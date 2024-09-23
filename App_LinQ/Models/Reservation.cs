using System;
using System.Collections.Generic;

namespace App_LinQ.Models;

public partial class Reservation
{
    public int ReservationId { get; set; }

    public int? TripId { get; set; }

    public string? TravellerName { get; set; }

    public DateOnly? ReservationData { get; set; }

    public int? NoOfTickets { get; set; }
}
