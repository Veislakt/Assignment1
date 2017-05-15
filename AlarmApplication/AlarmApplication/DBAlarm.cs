using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmApplication
{
    class DBAlarm
    {
        public DateTime ActivationTime { get; set; }
        public DateTime AcknowledgedTime { get; set; }
        public string AcknowledgedBy { get; set; }
        public string AlarmStatus { get; set; }
        public string Description { get; set; }
        public int Severity { get; set; }
        public string AlarmType { get; set; }
        public double AlarmLimit { get; set; }
        public string AlarmAudioVisual { get; set; }
        public string TagName { get; set; }
        public double Value { get; set; }
    }
}
