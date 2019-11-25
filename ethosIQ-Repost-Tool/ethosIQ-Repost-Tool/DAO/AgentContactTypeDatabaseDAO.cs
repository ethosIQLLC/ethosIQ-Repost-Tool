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
    public class AgentContactTypeDatabaseDAO
    {
        private Database Database;

        public AgentContactTypeDatabaseDAO(Database Database)
        {
            this.Database = Database;
        }

        public List<AgentContactType> GetAgentContactTypeData(long StartTime, long EndTime)
        {
            List<AgentContactType> agentContactTypes = new List<AgentContactType>();

            using (IDbConnection connection = Database.CreateOpenConnection())
            {
                using (IDbCommand command = Database.CreateStoredProcCommand("CTI_IEXAGENTCONTACTTYPE", connection))
                {
                    DataSet dataSet = new DataSet("Agent-Contact Type");
                    IDataAdapter adapter;

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

                        command.Parameters.Add(startTime);
                        command.Parameters.Add(endTime);

                        command.ExecuteNonQuery();

                        adapter = Database.CreateDataAdapter(Database.CreateCommand("SELECT DNQUEUE AS CT,AGENTID AS \"Agent ID\",HANDLEDCONTACTS AS \"Handled\",HANDLETIME AS \"HandleTime\",WORKTIME AS \"WorkTime\" FROM " + "CTIIEXAGENTCONTACTTYPE" + " ORDER BY DNQUEUE,AGENTID", connection));
                        adapter.Fill(dataSet);
                    }

                    if (dataSet != null)
                    {
                        foreach (DataRow row in dataSet.Tables[0].Rows)
                        {
                            agentContactTypes.Add(new AgentContactType(row["CT"] == DBNull.Value ? "" : row["CT"].ToString(),
                                                                        row["Agent ID"] == DBNull.Value ? "" : row["Agent ID"].ToString(),
                                                                        Convert.ToInt32(row["Handled"] == DBNull.Value ? 0 : row["Handled"]),
                                                                        Convert.ToInt32(row["HandleTime"] == DBNull.Value ? 0 : row["HandleTime"]),
                                                                        Convert.ToInt32(row["WorkTime"] == DBNull.Value ? 0 : row["WorkTime"])));
                        }
                    }
                }
            }

            return agentContactTypes;
        }


        public List<AgentContactType> GetAgentContactTypeMMData(long StartTime, long EndTime)
        {
            List<AgentContactType> agentContactTypes = new List<AgentContactType>();

            using (IDbConnection connection = Database.CreateOpenConnection())
            {
                using (IDbCommand command = Database.CreateStoredProcCommand("CTI_IEXAGENTCONTACTTYPEMM", connection))
                {
                    DataSet dataSet = new DataSet("Agent-Contact Type");
                    IDataAdapter adapter;

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

                        command.Parameters.Add(startTime);
                        command.Parameters.Add(endTime);

                        command.ExecuteNonQuery();

                        adapter = Database.CreateDataAdapter(Database.CreateCommand("SELECT DNQUEUE AS CT,AGENTID AS \"Agent ID\",HANDLEDCONTACTS AS \"Handled\",HANDLETIME AS \"HandleTime\",WORKTIME AS \"WorkTime\" FROM " + "CTIIEXAGENTCONTACTTYPEMM" + " ORDER BY DNQUEUE,AGENTID", connection));
                        adapter.Fill(dataSet);
                    }

                    if (dataSet != null)
                    {
                        foreach (DataRow row in dataSet.Tables[0].Rows)
                        {
                            agentContactTypes.Add(new AgentContactType(row["CT"] == DBNull.Value ? "" : row["CT"].ToString(),
                                                                        row["Agent ID"] == DBNull.Value ? "" : row["Agent ID"].ToString(),
                                                                        Convert.ToInt32(row["Handled"] == DBNull.Value ? 0 : row["Handled"]),
                                                                        Convert.ToInt32(row["HandleTime"] == DBNull.Value ? 0 : row["HandleTime"]),
                                                                        Convert.ToInt32(row["WorkTime"] == DBNull.Value ? 0 : row["WorkTime"])));
                        }
                    }
                }
            }

            return agentContactTypes;
        }
    }
}
