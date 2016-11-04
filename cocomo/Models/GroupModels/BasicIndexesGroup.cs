using cocomo.Models.ItemModels;
using System;
using System.Xml.Serialization;

namespace cocomo.Models.GroupModels
{
    [XmlRoot("table")]
    public class BasicIndexesGroup
    {
        [XmlArray("basicIndexes")]
        [XmlArrayItem("indexes")]
        public BasicIndexesItem[] Indexes { get; set; }
        
        public int SelectedIndexes { get; set; }
        public long Size { get; set; }
                
        public double PM
        {
            get
            {
                return Indexes[SelectedIndexes].a * Math.Pow(Size, Indexes[SelectedIndexes].b);
            }
            set {  }
        }

        public double TM
        {
            get
            {
                return Indexes[SelectedIndexes].c * Math.Pow(PM, Indexes[SelectedIndexes].d);
            }
            set { }
        }                
    }
}
