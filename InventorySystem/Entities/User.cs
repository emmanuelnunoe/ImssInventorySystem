using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImssInventorySystem.Models
{
    public class User
    {
        public int Id { get; set; }
        public string employeeId { get; set; }
        public string Name { get; set; }
        public string LastName{ get; set; }
        public string SecondLastName { get; set; }
    }
}
