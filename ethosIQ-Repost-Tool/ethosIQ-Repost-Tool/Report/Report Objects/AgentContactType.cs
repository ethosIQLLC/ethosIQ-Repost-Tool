using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ethosIQ_Repost_Tool.Report.Report_Objects
{
    public class AgentContactType
    {
        public string CT;
        public string AgentID;
        public int Handled;
        public int HandleTime;
        public int WorkTime;

        public AgentContactType(string CT, string AgentID, int Handled, int HandleTime, int WorkTime)
        {
            this.CT = CT;
            this.AgentID = AgentID;
            this.Handled = Handled;
            this.HandleTime = HandleTime;
            this.WorkTime = WorkTime;
        }

        public override string ToString()
        {
            return CT + "\t" + AgentID + "\t" + Handled + "\t" + HandleTime + "\t" + WorkTime + "\t";
        }
    }
}
