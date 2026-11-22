using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransport.Models
{
    internal class Terminals
    {
        public int TerminalId { get; set; }
        public int AirportId { get; set; }
        public bool Status { get; set; }
    }
}
