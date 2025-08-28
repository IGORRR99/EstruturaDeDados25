using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Queues
{
    public class IncomingCall
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime CallTime { get; set; }
        public DateTime StarTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Consultant { get; set; } = null!;

    }
}