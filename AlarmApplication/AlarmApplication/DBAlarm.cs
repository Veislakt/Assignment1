using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmApplication
{
    class DBAlarm
    {
        int AlarmId { get; set; }
        DateTime ActivationTime { get; set; }
        DateTime AcknowledgedTime { get; set; }
        string AcknowledgedBy { get; set; }
        string AlarmStatus { get; set; }
        string Tag { get; set; }
    }
}
