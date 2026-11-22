using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransport.Models
{
    internal class Aircraft
    {
        public int AircraftId { get; set; }
        public int AirlineId { get; set; }
        public string Model { get; set; }
        public int SeatCapacity { get; set; }
        public bool Status { get; set; }
    }
}
