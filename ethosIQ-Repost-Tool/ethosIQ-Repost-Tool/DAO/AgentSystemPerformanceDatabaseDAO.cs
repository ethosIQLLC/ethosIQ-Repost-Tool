using ethosIQ_Database;
using ethosIQ_Repost_Tool.Report.Report_Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ethosIQ_Repost_Tool.DAO
{
    public class AgentSystemPerformanceDatabaseDAO
    {
        private Database Database;

        public AgentSystemPerformanceDatabaseDAO(Database Database)
        {
            this.Database = Database;
        }

        public List<AgentSystemPerformance> GetAgentSystemPerformanceData(long StartTime, long EndTime)
        {
            List<AgentSystemPerformance> agentSystemPerformance = new List<AgentSystemPerformance>();

            using (IDbConnection connection = Database.CreateOpenConnection())
            {
                using (IDbCommand command = Database.CreateStoredProcCommand("CTI_IEXSYSTEMPERFORMANCE", connection))
                {
                    IDataAdapter adapter;
                    DataSet dataSet = new DataSet("Agent System Performance");

                    if (Database.DatabaseType == DatabaseType.MsSql)
                    {
                        IDataParameter startTime = Database.CreateParameter("@StartTime", StartTime);
                        startTime.Direction = ParameterDirection.Input;
                        IDataParameter endTime = Database.CreateParameter("@EndTime", EndTime);
                        endTime.Direction = ParameterDirection.Input;

                        command.Parameters.Add(startTime);
                        command.Parameters.Add(endTime);


                        adapter = Database.CreateDataAdapter(command);
                        adapter.Fill(dataSet);
                    }

                    else if (Database.DatabaseType == DatabaseType.Oracle || Database.DatabaseType == DatabaseType.OracleSN)
                    {
                        IDataParameter startTime = Database.CreateParameter("V_ST", StartTime);
                        startTime.Direction = ParameterDirection.Input;
                        IDataParameter endTime = Database.CreateParameter("V_ET", EndTime);
                        endTime.Direction = ParameterDirection.Input;
                        IDataParameter bk = Database.CreateParameter("V_BK", 0);
                        bk.Direction = ParameterDirection.Input;

                        command.Parameters.Add(startTime);
                        command.Parameters.Add(endTime);
                        command.Parameters.Add(bk);

                        command.ExecuteNonQuery();

                        adapter = Database.CreateDataAdapter(Database.CreateCommand("SELECT AGENTID AS \"Agent ID\",INTERNALCALLS AS \"InternalCalls\",INTERNALTIME AS \"InternalTime\",READYTIME AS \"ReadyTime\",IDLETIME AS \"IdleTime\",OUTCALLS AS \"OutCalls\",OUTTIME AS \"OutTime\",LOGINTIME AS \"LoginTime\"  FROM " + "CTIIEXSYSTEMPERFORMANCE" + " ORDER BY AGENTID", connection));
                        adapter.Fill(dataSet);

                    }

                    if (dataSet != null)
                    {
                        foreach (DataRow row in dataSet.Tables[0].Rows)
                        {
                            agentSystemPerformance.Add(new AgentSystemPerformance(row["Agent ID"] == DBNull.Value ? "" : row["Agent ID"].ToString(),
                                                                                    Convert.ToInt32(row["InternalCalls"] ?? 0),
                                                                                    Convert.ToInt32(row["InternalTime"] ?? 0),
                                                                                    Convert.ToInt32(row["ReadyTime"] == DBNull.Value ? 0 : row["ReadyTime"]),
                                                                                    Convert.ToInt32(row["IdleTime"] == DBNull.Value ? 0 : row["IdleTime"]),
                                                                                    Convert.ToInt32(row["OutCalls"] == DBNull.Value ? 0 : row["OutCalls"]),
                                                                                    Convert.ToInt32(row["OutTime"] == DBNull.Value ? 0 : row["OutTime"]),
                                                                                    Convert.ToInt32(row["LoginTime"] == DBNull.Value ? 0 : row["LoginTime"])));
                        }
                    }
                }
            }

            return agentSystemPerformance;
        }

        public List<AgentSystemPerformance> GetAgentSystemPerformanceMMData(long StartTime, long EndTime)
        {
            List<AgentSystemPerformance> agentSystemPerformance = new List<AgentSystemPerformance>();

            using (IDbConnection connection = Database.CreateOpenConnection())
            {
                using (IDbCommand command = Database.CreateStoredProcCommand("CTI_IEXSYSTEMPERFORMANCEMM", connection))
                {
                    IDataAdapter adapter;
                    DataSet dataSet = new DataSet("Agent System Performance");

                    if (Database.DatabaseType == DatabaseType.MsSql)
                    {
                        IDataParameter startTime = Database.CreateParameter("@StartTime", StartTime);
                        startTime.Direction = ParameterDirection.Input;
                        IDataParameter endTime = Database.CreateParameter("@EndTime", EndTime);
                        endTime.Direction = ParameterDirection.Input;

                        command.Parameters.Add(startTime);
                        command.Parameters.Add(endTime);


                        adapter = Database.CreateDataAdapter(command);
                        adapter.Fill(dataSet);
                    }

                    else if (Database.DatabaseType == DatabaseType.Oracle || Database.DatabaseType == DatabaseType.OracleSN)
                    {
                        IDataParameter startTime = Database.CreateParameter("V_ST", StartTime);
                        startTime.Direction = ParameterDirection.Input;
                        IDataParameter endTime = Database.CreateParameter("V_ET", EndTime);
                        endTime.Direction = ParameterDirection.Input;
                        IDataParameter bk = Database.CreateParameter("V_BK", 0);
                        bk.Direction = ParameterDirection.Input;

                        command.Parameters.Add(startTime);
                        command.Parameters.Add(endTime);
                        command.Parameters.Add(bk);

                        command.ExecuteNonQuery();

                        adapter = Database.CreateDataAdapter(Database.CreateCommand("SELECT AGENTID AS \"Agent ID\",INTERNALCALLS AS \"InternalCalls\",INTERNALTIME AS \"InternalTime\",READYTIME AS \"ReadyTime\",IDLETIME AS \"IdleTime\",OUTCALLS AS \"OutCalls\",OUTTIME AS \"OutTime\",LOGINTIME AS \"LoginTime\"  FROM " + "CTIIEXSYSTEMPERFORMANCEMM" + " ORDER BY AGENTID", connection));
                        adapter.Fill(dataSet);

                    }

                    if (dataSet != null)
                    {
                        foreach (DataRow row in dataSet.Tables[0].Rows)
                        {
                            agentSystemPerformance.Add(new AgentSystemPerformance(row["Agent ID"] == DBNull.Value ? "" : row["Agent ID"].ToString(),
                                                                                    Convert.ToInt32(row["InternalCalls"] ?? 0),
                                                                                    Convert.ToInt32(row["InternalTime"] ?? 0),
                                                                                    Convert.ToInt32(row["ReadyTime"] == DBNull.Value ? 0 : row["ReadyTime"]),
                                                                                    Convert.ToInt32(row["IdleTime"] == DBNull.Value ? 0 : row["IdleTime"]),
                                                                                    Convert.ToInt32(row["OutCalls"] == DBNull.Value ? 0 : row["OutCalls"]),
                                                                                    Convert.ToInt32(row["OutTime"] == DBNull.Value ? 0 : row["OutTime"]),
                                                                                    Convert.ToInt32(row["LoginTime"] == DBNull.Value ? 0 : row["LoginTime"])));
                        }
                    }
                }
            }

            return agentSystemPerformance;
        }
    }
}
