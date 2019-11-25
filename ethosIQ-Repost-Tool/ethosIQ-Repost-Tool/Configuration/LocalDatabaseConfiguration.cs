using ethosIQ_Database;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ethosIQ_Repost_Tool.Configuration
{
    public static class LocalDatabaseConfiguration
    {
        public static Database GetConfigurationDatabase()
        {
            return DatabaseFactory.CreateDatabase(ConfigurationManager.AppSettings["DatabaseType"].ToString(),
                                                  ConfigurationManager.AppSettings["DataSource"].ToString(),
                                                  ConfigurationManager.AppSettings["Server"].ToString(),
                                                  Convert.ToInt32(ConfigurationManager.AppSettings["Port"]),
                                                  ConfigurationManager.AppSettings["Username"].ToString(),
                                                  ConfigurationManager.AppSettings["Password"].ToString());
        }
    }
}
