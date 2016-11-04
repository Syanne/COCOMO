using System.Xml.Serialization;

namespace cocomo.Models.ItemModels
{
    [XmlRoot("indexes")]
    public class IntermediateValueItem
    {
        public double SelectedItem { get; set; }
        
        [XmlAttribute]
        public string name { get; set; }

        [XmlAttribute]
        public double verylow { get; set; }

        [XmlAttribute]
        public double low { get; set; }

        [XmlAttribute]
        public double middle { get; set; }

        [XmlAttribute]
        public double high { get; set; }

        [XmlAttribute]
        public double veryhigh { get; set; }

        [XmlAttribute]
        public double critical { get; set; }
    }
}