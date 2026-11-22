using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransport.Models
{
    internal class Bookings
    {
        public int BookingId { get; set; }
        public int PassengerCode { get; set; }
        public int FlightId { get; set; }
        public string BookingDate { get; set; }
        public int SeatId { get; set; }
        public string BookingStatus { get; set; }
        public double TicketPrice { get; set; }
        public bool Status { get; set; }
    }
}
