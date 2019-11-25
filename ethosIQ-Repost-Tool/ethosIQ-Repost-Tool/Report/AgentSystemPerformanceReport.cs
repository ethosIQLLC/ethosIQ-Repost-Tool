using ethosIQ_Repost_Tool.Report.Report_Objects;
using System;
using System.Collections.Generic;

namespace ethosIQ_Repost_Tool.Report
{
    public class AgentSystemPerformanceReport
    {
        public readonly string Name = "Agent System Performance Report";
        public readonly string EndName = "End Agent System Performance Report";
        public readonly string ColumnHeader = "Agent ID InternalCalls InternalTime ReadyTime IdleTime OutCalls OutTime LoginTime ";
        public List<AgentSystemPerformance> AgentSystemPerformances;
        DateTime ReportTime;
        public string ReportTimeString;

        public AgentSystemPerformanceReport(DateTime ReportTime)
        {
            this.ReportTime = ReportTime;

            ReportTimeString = ReportTime.ToString("MM/dd/yy HH:mm");
            AgentSystemPerformances = new List<AgentSystemPerformance>();
        }

        public void AddLine(AgentSystemPerformance AgentSystemPerformance)
        {
            if (AgentSystemPerformances != null)
            {
                AgentSystemPerformances.Add(AgentSystemPerformance);
            }
        }

        public override string ToString()
        {
            string Report = "";

            Report += Name;
            Report += ReportTimeString;
            Report += ColumnHeader;

            foreach (AgentSystemPerformance agentSystemPerformance in AgentSystemPerformances)
            {
                Report += agentSystemPerformance.ToString();
            }

            Report += EndName;

            return Report;

        }
    }
}
