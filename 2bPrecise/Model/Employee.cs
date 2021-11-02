using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bPrecise.Model
{
    public class Employee : BaseDbEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public Task[] Tasks { get; set; }
    }
}
