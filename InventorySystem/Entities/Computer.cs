using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImssInventorySystem.Models
{
    public class Computer
    {
        public int Id { get; set; }
        public string InventoryNumber { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string SerialNumber{ get; set; }

    }
}
