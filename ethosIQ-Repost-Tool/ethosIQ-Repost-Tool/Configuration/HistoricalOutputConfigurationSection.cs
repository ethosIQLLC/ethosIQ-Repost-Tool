using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ethosIQ_Repost_Tool.Configuration
{
    public class HistoricalOutputConfigurationSection : ConfigurationSection
    {
        public const string SectionName = "HistoricalOutputConfiguration";
        public const string CollectionName = "HistoricalOutputs";

        [ConfigurationProperty(CollectionName)]
        [ConfigurationCollection(typeof(HistoricalOutputCollection), AddItemName = "HistoricalOutput")]
        public HistoricalOutputCollection HistoricalOutputs { get { return (HistoricalOutputCollection)base[CollectionName]; } }
    }
}
