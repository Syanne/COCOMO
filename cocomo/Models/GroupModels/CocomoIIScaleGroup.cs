using cocomo.Models.ItemModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace cocomo.Models.GroupModels
{
    [XmlRoot("table")]
    public class CocomoIIScaleGroup
    {
        public string GroupName { get; set; }

        [XmlArray("cocomoIIScale")]
        [XmlArrayItem("indexes")]
        public CocomoIIScaleItem[] Indexes { get; set; }
    }
}