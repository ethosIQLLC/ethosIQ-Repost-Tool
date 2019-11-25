using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ethosIQ_Repost_Tool.Report.Report_Objects
{
    public class AgentSystemPerformance
    {
        public string AgentID;
        public int InternalCalls;
        public int InternalTime;
        public int ReadyTime;
        public int IdleTime;
        public int OutCalls;
        public int OutTime;
        public int LoginTime;

        public AgentSystemPerformance(string AgentID, int InternalCalls, int InternalTime, int ReadyTime, int IdleTime, int OutCalls, int OutTime, int LoginTime)
        {
            this.AgentID = AgentID;
            this.InternalCalls = InternalCalls;
            this.InternalTime = InternalTime;
            this.ReadyTime = ReadyTime;
            this.IdleTime = IdleTime;
            this.OutCalls = OutCalls;
            this.OutTime = OutTime;
            this.LoginTime = LoginTime;
        }

        public override string ToString()
        {
            return AgentID + "\t" + InternalCalls + "\t" + InternalTime + "\t" + ReadyTime + "\t" + IdleTime + "\t" + OutCalls + "\t" + OutTime + "\t" + LoginTime + "\t";
        }
    }
}
