using System.Xml.Serialization;

namespace cocomo.Models.ItemModels
{
    [XmlRoot("indexes")]
    public class CocomoIIScaleItem
    {
        [XmlAttribute]
        public int ID { get; set; }

        [XmlAttribute]
        public string name { get; set; }

        [XmlAttribute]
        public double? verylow { get; set; }

        [XmlAttribute]
        public double? low { get; set; }

        [XmlAttribute]
        public double? nominal { get; set; }

        [XmlAttribute]
        public double? high { get; set; }

        [XmlAttribute]
        public double? veryhigh { get; set; }

        [XmlAttribute]
        public double? extrahigh { get; set; }
    }
}