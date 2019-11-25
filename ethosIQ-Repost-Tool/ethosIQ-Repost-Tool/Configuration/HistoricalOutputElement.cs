using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ethosIQ_Repost_Tool.Configuration
{
    public class HistoricalOutputElement : ConfigurationElement
    {
        [ConfigurationProperty("Name", IsRequired = true)]
        public string Name
        {
            get { return (string)this["Name"]; }
            set { this["Name"] = value; }
        }

        [ConfigurationProperty("FTPType", IsRequired = true)]
        public string FTPType
        {
            get { return (string)this["FTPType"]; }
            set { this["FTPType"] = value; }
        }

        [ConfigurationProperty("Host", IsRequired = true)]
        public string Host
        {
            get { return (string)this["Host"]; }
            set { this["Host"] = value; }
        }

        [ConfigurationProperty("Port", IsRequired = true)]
        public int Port
        {
            get { return (int)this["Port"]; }
            set { this["Port"] = value; }
        }

        [ConfigurationProperty("Directory", IsRequired = true)]
        public string Directory
        {
            get { return (string)this["Directory"]; }
            set { this["Directory"] = value; }
        }

        [ConfigurationProperty("Username", IsRequired = true)]
        public string Username
        {
            get { return (string)this["Username"]; }
            set { this["Username"] = value; }
        }

        [ConfigurationProperty("Password", IsRequired = true)]
        public string Password
        {
            get { return (string)this["Password"]; }
            set { this["Password"] = value; }
        }

        [ConfigurationProperty("PSFTPPath", IsRequired = true)]
        public string PSFTPPath
        {
            get { return (string)this["PSFTPPath"]; }
            set { this["PSFTPPath"] = value; }
        }

        [ConfigurationProperty("BatchFilePath", IsRequired = true)]
        public string BatchFilePath
        {
            get { return (string)this["BatchFilePath"]; }
            set { this["BatchFilePath"] = value; }
        }
    }
}
