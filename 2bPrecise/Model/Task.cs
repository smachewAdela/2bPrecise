using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bPrecise.Model
{
    public class Task : BaseDbEntity
    {
        public string TasksText { get; set; }
        public DateTime AssignDate { get; set; }
        public DateTime DueDate { get; set; }
    }
}
