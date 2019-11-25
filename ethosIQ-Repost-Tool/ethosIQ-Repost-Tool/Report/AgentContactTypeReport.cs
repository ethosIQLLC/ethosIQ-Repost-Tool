using ethosIQ_Repost_Tool.Report.Report_Objects;
using System;
using System.Collections.Generic;

namespace ethosIQ_Repost_Tool.Report
{
    public class AgentContactTypeReport
    {
        public readonly string Name = "Agent-Contact Type Report";
        public readonly string EndName = "End Agent-Contact Type Report";
        public readonly string ColumnHeader = "CT Agent ID Handled HandleTime WorkTime ";
        public List<AgentContactType> AgentContactTypes;
        DateTime ReportTime;
        public string ReportTimeString;

        public AgentContactTypeReport(DateTime ReportTime)
        {
            this.ReportTime = ReportTime;

            ReportTimeString = ReportTime.ToString("MM/dd/yy HH:mm");
            AgentContactTypes = new List<AgentContactType>();
        }

        public void AddLine(AgentContactType AgentContactType)
        {
            if (AgentContactTypes != null)
            {
                AgentContactTypes.Add(AgentContactType);
            }
        }

        public override string ToString()
        {
            string Report = "";

            Report += Name;
            Report += ReportTimeString;
            Report += ColumnHeader;

            foreach (AgentContactType agentContactType in AgentContactTypes)
            {
                Report += agentContactType.ToString();
            }

            Report += EndName;

            return Report;

        }
    }
}
