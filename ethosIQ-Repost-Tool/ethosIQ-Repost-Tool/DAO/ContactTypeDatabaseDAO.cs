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
    public class ContactTypeDatabaseDAO
    {
        private Database Database;

        public ContactTypeDatabaseDAO(Database Database)
        {
            this.Database = Database;
        }

        public List<ContactType> GetContactTypeData(long StartTime, long EndTime)
        {
            List<ContactType> contactTypes = new List<ContactType>();

            using (IDbConnection connection = Database.CreateOpenConnection())
            {
                using (IDbCommand command = Database.CreateStoredProcCommand("CTI_IEXCONTACTTYPE", connection))
                {
                    IDataAdapter adapter;
                    DataSet dataSet = new DataSet("Contact Type");

                    if (Database.DatabaseType == DatabaseType.MsSql)
                    {
                        command.CommandTimeout = 0;

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

                        adapter = Database.CreateDataAdapter(Database.CreateCommand("SELECT DNQUEUE AS CT,RECEIVED AS \"Received\",HANDLED AS \"Handled\",ABAN AS \"Aban\",ANSGOS AS \"Ans-GOS\",ABAGOS AS \"Aba-GOS\",HANDLETIME AS \"HandleTime\",WORKTIME AS \"WorkTime\",DISTR AS \"Distributed\",QDELAY AS \"Q-Delay\",TO_CHAR(SRLVL) AS \"SrLvl\" FROM CTIIEXCONTACTTYPE ORDER BY DNQUEUE,RECEIVED,HANDLED", connection));
                        adapter.Fill(dataSet);
                    }

                    if (dataSet != null)
                    {
                        foreach (DataRow row in dataSet.Tables[0].Rows)
                        {

                            contactTypes.Add(new ContactType(row["CT"] == DBNull.Value ? "" : row["CT"].ToString(),
                                                             Convert.ToInt32(row["Received"] == DBNull.Value ? 0 : row["Received"]),
                                                             Convert.ToInt32(row["Handled"] == DBNull.Value ? 0 : row["Handled"]),
                                                             Convert.ToInt32(row["Aban"] == DBNull.Value ? 0 : row["Aban"]),
                                                             Convert.ToInt32(row["Ans-Gos"] == DBNull.Value ? 0 : row["Ans-Gos"]),
                                                             Convert.ToInt32(row["Aba-Gos"] == DBNull.Value ? 0 : row["Aba-Gos"]),
                                                             Convert.ToInt32(row["HandleTime"] == DBNull.Value ? 0 : row["HandleTime"]),
                                                             Convert.ToInt32(row["WorkTime"] == DBNull.Value ? 0 : row["WorkTime"]),
                                                             Convert.ToInt32(row["Distributed"] == DBNull.Value ? 0 : row["Distributed"]),
                                                             Convert.ToInt32(row["Q-Delay"] == DBNull.Value ? 0 : row["Q-Delay"]),
                                                             Convert.ToInt32(row["Srlvl"] == DBNull.Value ? 0 : row["Srlvl"])));
                        }
                    }
                }
            }

            return contactTypes;
        }

        public List<ContactTypeMM> GetContactTypeMMData(long StartTime, long EndTime)
        {
            List<ContactTypeMM> contactTypes = new List<ContactTypeMM>();

            using (IDbConnection connection = Database.CreateOpenConnection())
            {
                using (IDbCommand command = Database.CreateStoredProcCommand("CTI_IEXCONTACTTYPEMM", connection))
                {
                    IDataAdapter adapter;
                    DataSet dataSet = new DataSet("Contact Type");

                    if (Database.DatabaseType == DatabaseType.MsSql)
                    {
                        command.CommandTimeout = 0;

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

                        adapter = Database.CreateDataAdapter(Database.CreateCommand("SELECT DNQUEUE AS CT,RECEIVED AS \"Received\",HANDLED AS \"Handled\",ABAN AS \"Aban\",ANSGOS AS \"Ans-GOS\",ABAGOS AS \"Aba-GOS\",HANDLETIME AS \"HandleTime\",WORKTIME AS \"WorkTime\",DISTR AS \"Distributed\",QDELAY AS \"Q-Delay\",TO_CHAR(SRLVL) AS \"SrLvl\",BLOG AS \"Blog\",BLOGNOTEXP AS \"BlogNotExp\",BLOGEXP AS \"BlogExp\" FROM CTIIEXCONTACTTYPEMM ORDER BY DNQUEUE,RECEIVED,HANDLED", connection));
                        adapter.Fill(dataSet);
                    }

                    if (dataSet != null)
                    {
                        foreach (DataRow row in dataSet.Tables[0].Rows)
                        {

                            contactTypes.Add(new ContactTypeMM(row["CT"] == DBNull.Value ? "" : row["CT"].ToString(),
                                                             Convert.ToInt32(row["Received"] == DBNull.Value ? 0 : row["Received"]),
                                                             Convert.ToInt32(row["Handled"] == DBNull.Value ? 0 : row["Handled"]),
                                                             Convert.ToInt32(row["Aban"] == DBNull.Value ? 0 : row["Aban"]),
                                                             Convert.ToInt32(row["Ans-Gos"] == DBNull.Value ? 0 : row["Ans-Gos"]),
                                                             Convert.ToInt32(row["Aba-Gos"] == DBNull.Value ? 0 : row["Aba-Gos"]),
                                                             Convert.ToInt32(row["HandleTime"] == DBNull.Value ? 0 : row["HandleTime"]),
                                                             Convert.ToInt32(row["WorkTime"] == DBNull.Value ? 0 : row["WorkTime"]),
                                                             Convert.ToInt32(row["Distributed"] == DBNull.Value ? 0 : row["Distributed"]),
                                                             Convert.ToInt32(row["Q-Delay"] == DBNull.Value ? 0 : row["Q-Delay"]),
                                                             Convert.ToInt32(row["Srlvl"] == DBNull.Value ? 0 : row["Srlvl"]),
                                                             Convert.ToInt32(row["Blog"] == DBNull.Value ? 0 : row["Blog"]),
                                                             Convert.ToInt32(row["BlogNotExp"] == DBNull.Value ? 0 : row["BlogNotExp"]),
                                                             Convert.ToInt32(row["BlogExp"] == DBNull.Value ? 0 : row["BlogExp"])));
                        }
                    }
                }
            }

            return contactTypes;
        }
    }
}
