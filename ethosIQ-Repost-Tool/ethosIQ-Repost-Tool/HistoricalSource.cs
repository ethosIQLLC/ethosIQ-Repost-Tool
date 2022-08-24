using ethosIQ_Database;
using ethosIQ_Repost_Tool.DAO;
using ethosIQ_Repost_Tool.Report.Report_Objects;
using System.Collections.Generic;

namespace ethosIQ_Repost_Tool
{
    public class HistoricalSource
    {
        public string Name;
        public Database Database;
        private AgentContactTypeDatabaseDAO AgentContactTypeDatabaseDAO;
        private ContactTypeDatabaseDAO ContactTypeDatabaseDAO;
        private AgentSystemPerformanceDatabaseDAO AgentSystemPerformanceDatabaseDAO;
        private AgentSignOnOffDatabaseDAO AgentSignOnOffDatabaseDAO;

        public HistoricalSource(string Name, Database Database)
        {
            this.Name = Name;
            this.Database = Database;

            ContactTypeDatabaseDAO = new ContactTypeDatabaseDAO(Database);
            AgentContactTypeDatabaseDAO = new AgentContactTypeDatabaseDAO(Database);
            AgentSystemPerformanceDatabaseDAO = new AgentSystemPerformanceDatabaseDAO(Database);
            AgentSignOnOffDatabaseDAO = new AgentSignOnOffDatabaseDAO(Database);
        }

        public List<AgentContactType> GetAgentContactTypeReport(long StartTime, long EndTime)
        {
            return AgentContactTypeDatabaseDAO.GetAgentContactTypeData(StartTime, EndTime);
        }

        public List<AgentContactType> GetAgentContactTypeMMReport(long StartTime, long EndTime)
        {
            return AgentContactTypeDatabaseDAO.GetAgentContactTypeMMData(StartTime, EndTime);
        }

        public List<ContactType> GetContactTypeReport(long StartTime, long EndTime)
        {
            return ContactTypeDatabaseDAO.GetContactTypeData(StartTime, EndTime);
        }

        public List<ContactTypeMM> GetContactTypeMMReport(long StartTime, long EndTime)
        {
            return ContactTypeDatabaseDAO.GetContactTypeMMData(StartTime, EndTime);
        }

        public List<AgentSystemPerformance> GetAgentSystemPerformanceReport(long StartTime, long EndTime)
        {
            return AgentSystemPerformanceDatabaseDAO.GetAgentSystemPerformanceData(StartTime, EndTime);
        }

        public List<AgentSystemPerformance> GetAgentSystemPerformanceMMReport(long StartTime, long EndTime)
        {
            return AgentSystemPerformanceDatabaseDAO.GetAgentSystemPerformanceMMData(StartTime, EndTime);
        }

        public List<AgentSignOnSignOff> GetAgentSignOnSignOffReport(long StartTime, long EndTime)
        {
            return AgentSignOnOffDatabaseDAO.GetAgentSignOnOffData(StartTime, EndTime);
        }
        public List<AgentSignOnSignOff> GetAgentSignOnSignOffMMReport(long StartTime, long EndTime)
        {
            return AgentSignOnOffDatabaseDAO.GetAgentSignOnSignOffMMData(StartTime, EndTime);
        }
    }
}
