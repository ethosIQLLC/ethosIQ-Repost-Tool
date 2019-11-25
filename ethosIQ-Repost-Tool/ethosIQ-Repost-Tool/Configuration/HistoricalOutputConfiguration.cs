using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ethosIQ_Repost_Tool.Configuration
{
    public class HistoricalOutputConfiguration
    {
        private static List<HistoricalOutputElement> HistoricalOutputs = new List<HistoricalOutputElement>();

        public static List<HistoricalOutputElement> GetConfigurationFromFile()
        {
            var CustomSection = ConfigurationManager.GetSection(HistoricalOutputConfigurationSection.SectionName) as HistoricalOutputConfigurationSection;

            if (CustomSection != null)
            {
                foreach (HistoricalOutputElement HistoricalOutput in CustomSection.HistoricalOutputs)
                {
                    HistoricalOutputs.Add(HistoricalOutput);
                }
            }

            return HistoricalOutputs;
        }
    }
}
