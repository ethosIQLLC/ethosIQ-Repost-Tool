using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ethosIQ_Repost_Tool.Configuration
{
    public class HistoricalOutputCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new HistoricalOutputElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((HistoricalOutputElement)element).Name;
        }
    }
}
