using cocomo.Models.ItemModels;
using System;
using System.Linq;
using System.Xml.Serialization;

namespace cocomo.Models.GroupModels
{
    [XmlRoot("table")]
    public class IntermediateIndexesGroup
    {
        [XmlArray("intermediateIndexes")]
        [XmlArrayItem("indexes")]
        public IntermediateIndexesItem[] SmallTable { get; set; }

        [XmlArray("intertmediateValue")]
        [XmlArrayItem("indexes")]
        public IntermediateValueItem[] BigTable { get; set; }
        
        public int SelectedIndexes { get; set; }
        public long Size { get; set; }

        public double PM
        {
            get
            {
                double EAF = 1;
                foreach (var value in BigTable)
                    EAF *= value.SelectedItem;

                return EAF * SmallTable[SelectedIndexes].a * Math.Pow(Size, SmallTable[SelectedIndexes].b);
            }
            set { }
        }

        public double TM
        {
            get
            {
                return SmallTable[SelectedIndexes].c * Math.Pow(PM, SmallTable[SelectedIndexes].d);
            }
            set { }
        }
    }
}