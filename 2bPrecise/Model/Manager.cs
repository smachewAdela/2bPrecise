using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bPrecise.Model
{
    public class Manager : Employee
    {
        public Employee[] Subordinates { get; set; }
    }
}
