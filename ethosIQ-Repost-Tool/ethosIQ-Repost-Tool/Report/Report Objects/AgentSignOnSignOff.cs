using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ethosIQ_Repost_Tool.Report.Report_Objects
{
    public class AgentSignOnSignOff
    {
        public string AgentID;
        public string SignIn;
        public string SignOut;
        public string Reason;

        public AgentSignOnSignOff(string AgentID, string SignIn, string SignOut, string Reason)
        {
            this.AgentID = AgentID;
            this.SignIn = SignIn;
            this.SignOut = SignOut;
            this.Reason = Reason;
        }

        public override string ToString()
        {
            return AgentID + "\t" + SignIn + "\t" + SignOut + "\t" + Reason + "\t";
        }
    }
}
