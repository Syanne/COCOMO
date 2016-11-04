using System.Xml.Serialization;

namespace cocomo.Models.ItemModels
{
    [XmlRoot("indexes")]
    public class IntermediateIndexesItem
    {
        [XmlAttribute]
        public int ID { get; set; }

        [XmlAttribute]
        public string name { get; set; }

        [XmlAttribute("a")]
        public double a { get; set; }

        [XmlAttribute("b")]
        public double b { get; set; }

        [XmlAttribute("c")]
        public double c { get; set; }

        [XmlAttribute("d")]
        public double d { get; set; }
    }
}