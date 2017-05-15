using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmApplication
{
    class Alarm
    {
        public int AlarmId { get; set; }
        public int TagId { get; set; }
        public DateTime ActivationTime { get; set; }
        public DateTime AcknowledgedTime { get; set; }
        public string AcknowledgedBy { get; set; }
        public int AlarmConfigId { get; set; }
        public string AlarmStatus { get; set; }
        public string Description { get; set; }
        public int Severity { get; set; }
        
        public Alarm(int alarmId, int tagId, DateTime activationTime, int alarmConfigId, string alarmStatus, int severity)
        {
            this.AlarmId = alarmId;
            this.TagId = tagId;
            this.ActivationTime = activationTime;
            this.AlarmConfigId = alarmConfigId;
            this.AlarmStatus = alarmStatus;
            this.Severity = severity;
        }

        public Alarm(int alarmId, int tagId, DateTime activationTime, int alarmConfigId, string alarmStatus, int severity, string description)
        {
            this.AlarmId = alarmId;
            this.TagId = tagId;
            this.ActivationTime = activationTime;
            this.AlarmConfigId = alarmConfigId;
            this.AlarmStatus = alarmStatus;
            this.Severity = severity;
            this.Description = description;
        }
    }
}
