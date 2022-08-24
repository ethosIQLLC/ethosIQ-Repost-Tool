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
    public class AgentSignOnOffDatabaseDAO
    {
        private Database Database;

        public AgentSignOnOffDatabaseDAO(Database Database)
        {
            this.Database = Database;
        }

        public List<AgentSignOnSignOff> GetAgentSignOnOffData(long StartTime, long EndTime)
        {
            List<AgentSignOnSignOff> agentSignOnSignOffs = new List<AgentSignOnSignOff>();
            long DayStartTime = EndTime - 86399;

            using (IDbConnection connection = Database.CreateOpenConnection())
            {
                using (IDbCommand command = Database.CreateStoredProcCommand("CTI_IEXAGENTSIGNONOFF", connection))
                {
                    DataSet dataSet = new DataSet("Agent Signon-Signoff");
                    IDataAdapter adapter;

                    if (Database.DatabaseType == DatabaseType.MsSql)
                    {
                        command.CommandTimeout = 0;

                        IDataParameter startTime = Database.CreateParameter("@StartTime", DayStartTime);
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
                        //connection.Open();

                        IDataParameter startTime = Database.CreateParameter("V_ST", DayStartTime);
                        startTime.Direction = ParameterDirection.Input;
                        IDataParameter endTime = Database.CreateParameter("V_ET", EndTime);
                        endTime.Direction = ParameterDirection.Input;
                        IDataParameter off = Database.CreateParameter("V_OFF", "0");
                        off.Direction = ParameterDirection.Input;

                        command.Parameters.Add(startTime);
                        command.Parameters.Add(endTime);
                        command.Parameters.Add(off);

                        command.ExecuteNonQuery();

                        adapter = Database.CreateDataAdapter(Database.CreateCommand("SELECT AGENTID AS \"Agent ID\",SIGNIN AS \"Sign In\",SIGNOUT AS \"Sign Out\",REASON AS \"Reason Code\" FROM " + "CTIIEXAGENTSIGNONOFF" + " ORDER BY AGENTID,SIGNOUT", connection));
                        adapter.Fill(dataSet);
                    }

                    if (command.Transaction != null)
                    {
                        command.Transaction.Commit();
                    }

                    if (dataSet != null)
                    {
                        foreach (DataRow row in dataSet.Tables[0].Rows)
                        {
                            agentSignOnSignOffs.Add(new AgentSignOnSignOff(row["Agent ID"] == DBNull.Value ? "" : row["Agent ID"].ToString(),
                                                                           row["Sign In"] == DBNull.Value ? "" : row["Sign In"].ToString(),
                                                                           row["Sign Out"] == DBNull.Value ? "" : row["Sign Out"].ToString(),
                                                                           row["Reason Code"] == DBNull.Value ? "" : row["Reason Code"].ToString()));

                        }
                    }
                }
            }

            return agentSignOnSignOffs;
        }


        public List<AgentSignOnSignOff> GetAgentSignOnSignOffMMData(long StartTime, long EndTime)
        {
            List<AgentSignOnSignOff> agentSignOnSignOffs = new List<AgentSignOnSignOff>();
            long DayStartTime = EndTime - 86399;

            using (IDbConnection connection = Database.CreateOpenConnection())
            {
                using (IDbCommand command = Database.CreateStoredProcCommand("CTI_IEXAGENTSIGNONOFFMM", connection))
                {
                    DataSet dataSet = new DataSet("Agent Signon-Signoff");
                    IDataAdapter adapter;

                    if (Database.DatabaseType == DatabaseType.MsSql)
                    {
                        command.CommandTimeout = 0;

                        IDataParameter startTime = Database.CreateParameter("@StartTime", DayStartTime);
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
                       // connection.Open();
                        IDataParameter startTime = Database.CreateParameter("V_ST", DayStartTime);
                        startTime.Direction = ParameterDirection.Input;
                        IDataParameter endTime = Database.CreateParameter("V_ET", EndTime);
                        endTime.Direction = ParameterDirection.Input;
                        IDataParameter off = Database.CreateParameter("V_OFF", "0");
                        off.Direction = ParameterDirection.Input;

                        command.Parameters.Add(startTime);
                        command.Parameters.Add(endTime);
                        command.Parameters.Add(off);

                        command.ExecuteNonQuery();

                        adapter = Database.CreateDataAdapter(Database.CreateCommand("SELECT AGENTID AS \"Agent ID\",SIGNIN AS \"Sign In\",SIGNOUT AS \"Sign Out\",REASON AS \"Reason Code\" FROM " + "CTIIEXAGENTSIGNONOFFMM" + " ORDER BY AGENTID,SIGNOUT", connection));
                        adapter.Fill(dataSet);
                    }

                    if (command.Transaction != null)
                    {
                        command.Transaction.Commit();
                    }

                    if (dataSet != null)
                    {
                        foreach (DataRow row in dataSet.Tables[0].Rows)
                        {
                            agentSignOnSignOffs.Add(new AgentSignOnSignOff(row["Agent ID"] == DBNull.Value ? "" : row["Agent ID"].ToString(),
                                                                            row["Sign In"] == DBNull.Value ? "" : row["Sign In"].ToString(),
                                                                            row["Sign Out"] == DBNull.Value ? "" : row["Sign Out"].ToString(),
                                                                            row["Reason Code"] == DBNull.Value ? "" : row["Reason Code"].ToString()));
                        }
                    }
                }
            }

            return agentSignOnSignOffs;
        }
    }
}
