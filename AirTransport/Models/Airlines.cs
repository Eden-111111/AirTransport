using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransport.Models
{
    internal class Airlines
    {

        public int AirlineId { get; set; }
        public string AirlineName { get; set; }
        public string Country { get; set; }
        public bool Status { get; set; }
    }
}
