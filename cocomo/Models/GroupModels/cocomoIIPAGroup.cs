using cocomo.Models.ItemModels;
using System.Xml.Serialization;

namespace cocomo.Models.GroupModels
{
    [XmlRoot("table")]
    public class CocomoIIPAGroup
    {
        public string GroupName { get; set; }

        [XmlArray("cocomoIIPA")]
        [XmlArrayItem("indexes")]
        public CocomoIIPAItem[] Indexes { get; set; }
    }
}