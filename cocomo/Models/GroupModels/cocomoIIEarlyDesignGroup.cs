using cocomo.Models.ItemModels;
using System.Xml.Serialization;

namespace cocomo.Models.GroupModels
{
    [XmlRoot("table")]
    public class CocomoIIEarlyDesignGroup
    {
        public string GroupName { get; set; }

        [XmlArray("cocomoIIEarlyDesign")]
        [XmlArrayItem("indexes")]
        public CocomoIIEarlyDesignItem[] Indexes { get; set; }
    }
}