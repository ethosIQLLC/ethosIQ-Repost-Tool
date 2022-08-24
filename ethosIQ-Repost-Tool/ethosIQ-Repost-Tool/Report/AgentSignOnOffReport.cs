using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ethosIQ_Repost_Tool.Report.Report_Objects;


namespace ethosIQ_Repost_Tool.Report
{
    public class AgentSignOnOffReport
    {
        public readonly string Name = "Agent Signon-Signoff Report";
        public readonly string EndName = "End Agent Signon-Signoff Report";
        public readonly string ColumnHeader = "Agent ID Sign In Sign Out Reason Code ";
        public List<AgentSignOnSignOff> AgentSignOnSignOffs;
        DateTime ReportTime;
        public string ReportTimeString;

        public AgentSignOnOffReport(DateTime ReportTime)
        {
            this.ReportTime = ReportTime;

            ReportTimeString = ReportTime.ToString("MM/dd/yy HH:mm");
            AgentSignOnSignOffs = new List<AgentSignOnSignOff>();
        }

        public void AddLine(AgentSignOnSignOff agentSignOnOff)
        {
            if (AgentSignOnSignOffs != null)
            {
                AgentSignOnSignOffs.Add(agentSignOnOff);
            }
        }

        public override string ToString()
        {
            string Report = "";

            Report += Name;
            Report += ReportTimeString;
            Report += ColumnHeader;

            foreach (AgentSignOnSignOff agentSignOnOff in AgentSignOnSignOffs)
            {
                Report += agentSignOnOff.ToString();
            }

            Report += EndName;

            return Report;

        }
    }
}
