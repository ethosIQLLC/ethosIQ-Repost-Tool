using ethosIQ_Repost_Tool.Report.Report_Objects;
using System;
using System.Collections.Generic;

namespace ethosIQ_Repost_Tool.Report
{
    public class ContactTypeMMReport
    {
        public readonly string Name = "Contact Type Report";
        public readonly string EndName = "End Contact Type Report";
        public readonly string ColumnHeader = "CT Received Handled Aban Ans-Gos Aba-Gos HandleTime WorkTime Distributed Q-Delay Srlvl Blog BlogNotExp BlogExp";
        public List<ContactTypeMM> ContactTypes;
        DateTime ReportTime;
        public string ReportTimeString;

        public ContactTypeMMReport(DateTime ReportTime)
        {
            this.ReportTime = ReportTime;

            ReportTimeString = ReportTime.ToString("MM/dd/yy HH:mm");
            ContactTypes = new List<ContactTypeMM>();
        }

        public void AddLine(ContactTypeMM ContactType)
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

            foreach (ContactTypeMM contactType in ContactTypes)
            {
                Report += contactType.ToString();
            }

            Report += EndName;

            return Report;

        }
    }
}
