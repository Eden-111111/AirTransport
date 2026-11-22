using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransport.Models
{
    internal class Flights
    {

        public int FlightId { get; set; }
        public int AircraftId { get; set; }
        public int DepartureAirportId { get; set; }
        public int ArrivalAirportId { get; set; }
        public string DepartureDate { get; set; }
        public string Status { get; set; }
        public string DepartureTime { get; set; }
        public bool Status1 { get; set; }
    }
}
