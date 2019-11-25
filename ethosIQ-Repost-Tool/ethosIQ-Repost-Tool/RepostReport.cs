using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ethosIQ_Repost_Tool
{
    public class RepostReport
    {
        public DateTime StartTime;
        public long StartTimeSeconds;
        public long EndTimeSeconds;
        public bool Pass;

        public RepostReport(DateTime StartTime, long StartTimeSeconds, long EndTimeSeconds)
        {
            this.StartTime = StartTime;
            this.StartTimeSeconds = StartTimeSeconds;
            this.EndTimeSeconds = EndTimeSeconds;
        }
    }
}
