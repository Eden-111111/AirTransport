using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransport.Models
{
    internal class Baggage
    {
        public int BaggageId { get; set; }
        public int BookingId { get; set; }
        public string BaggageTag { get; set; }
        public double Weight { get; set; }
        public string BaggageType { get; set; }
        public string Status { get; set; }
        public bool Status1 { get; set; }
    }
}
