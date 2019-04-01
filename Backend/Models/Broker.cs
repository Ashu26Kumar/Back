using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class Broker
    {
        public short id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public float commission { get; set; }
        public byte isActive { get; set; }
    }
}
