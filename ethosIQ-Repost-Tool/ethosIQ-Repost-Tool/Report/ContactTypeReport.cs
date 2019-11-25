using ethosIQ_Repost_Tool.Report.Report_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ethosIQ_Repost_Tool.Report
{
    public class ContactTypeReport
    {
        public readonly string Name = "Contact Type Report";
        public readonly string EndName = "End Contact Type Report";
        public readonly string ColumnHeader = "CT Received Handled Aban Ans-Gos Aba-Gos HandleTime WorkTime Distributed Q-Delay Srlvl ";
        public List<ContactType> ContactTypes;
        DateTime ReportTime;
        public string ReportTimeString;

        public ContactTypeReport(DateTime ReportTime)
        {
            this.ReportTime = ReportTime;

            ReportTimeString = ReportTime.ToString("MM/dd/yy HH:mm");
            ContactTypes = new List<ContactType>();
        }

        public void AddLine(ContactType ContactType)
        {
            if (ContactTypes != null)
            {
                ContactTypes.Add(ContactType);
            }
        }

        public override string ToString()
        {
            string Report = "";

            Report += Name;
            Report += ReportTimeString;
            Report += ColumnHeader;

            foreach (ContactType contactType in ContactTypes)
            {
                Report += contactType.ToString();
            }

            Report += EndName;

            return Report;

        }
    }
}
