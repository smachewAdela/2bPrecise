using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bPrecise.Model
{
    public class Report : BaseDbEntity
    {
        public string ReportText { get; set; }
        public DateTime ReportDate { get; set; }
    }
}
