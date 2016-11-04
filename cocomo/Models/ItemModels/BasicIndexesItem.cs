using System;
using System.Xml.Serialization;

namespace cocomo.Models.ItemModels
{
    [XmlRoot("indexes")]
    public class BasicIndexesItem
    {
        [XmlAttribute]
        public int ID { get; set; }

        [XmlAttribute]
        public string name { get; set; }

        [XmlAttribute]
        public double a { get; set; }

        [XmlAttribute]
        public double b { get; set; }

        [XmlAttribute]
        public double c { get; set; }

        [XmlAttribute]
        public double d { get; set; }
    }
}
