using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBClassMonitoring
{
    class DBMeasurements
    {
        public int MeasId { get; set; }
        public double Value { get; set; }
        public DateTime TimeStamp { get; set; }
        public int TagId { get; set; }
        public string TagName { get; set; }
    }
}
