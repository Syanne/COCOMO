using cocomo.Models.ItemModels;
using System;
using System.Linq;
using System.Xml.Serialization;

namespace cocomo.Models.GroupModels
{
    [XmlRoot("table")]
    public class CocomoIIEDGroup
    {
        [XmlArray("cocomoIIEarlyDesign")]
        [XmlArrayItem("indexes")]
        public CocomoIIEDItem[] CocomoIIEDItems { get; set; }
        
        [XmlArray("cocomoIIScale")]
        [XmlArrayItem("indexes")]
        public CocomoIIScaleItem[] CocomoIIScaleItems { get; set; }

        const double A = 2.42;
        const double B = 0.91;

        private double E
        {
            get
            {
                return 0.91 + 0.01 * CocomoIIScaleItems.Sum(x => x.SelectedItem);
            }
            set { }
        }

        public double PM
        {
            get
            {
                double EAF = 1;
                foreach (var value in CocomoIIEDItems)
                    EAF *= value.SelectedItem;

                return EAF * A * Math.Pow(Size, E);
            }
            set { }
        }


        /// <summary>
        /// трудоемкость
        /// </summary>
        public double TM
        {
            get
            {
                double power = 0.28 + 0.2 * (E - B);
                double SCED = CocomoIIEDItems.LastOrDefault().SelectedItem;

                return SCED * 3.67 * Math.Pow(PM/SCED, power);
            }
            set { }
        }

        /// <summary>
        /// количество строк кода
        /// </summary>
        public long Size { get; set; }
    }
}