using System;
using System.Collections.Generic;
using System.Text;

namespace Anwesenheit
{
    public class Attendee
    {
        public int id;
        public string name;
        public TimeSpan? logginTime;
        public TimeSpan? loggoutTime;
        public Attendee(int id, string name, TimeSpan? logginTime, TimeSpan? loggoutTime)
        {
            this.id = id;
            this.name = name;
            this.logginTime = logginTime;
            this.loggoutTime = loggoutTime;
        }
    }
}
