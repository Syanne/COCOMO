using cocomo.Models.ItemModels;
using System;
using System.Linq;
using System.Xml.Serialization;

namespace cocomo.Models.GroupModels
{
    [XmlRoot("table")]
    public class CocomoIIPAGroup
    {
        public string GroupName { get; set; }

        [XmlArray("cocomoIIPA")]
        [XmlArrayItem("indexes")]
        public CocomoIIPAItem[] CocomoIIPAItems { get; set; }


        [XmlArray("cocomoIIScale")]
        [XmlArrayItem("indexes")]
        public CocomoIIScaleItem[] CocomoIIScaleItems { get; set; }

        private double A = 2.94;
        private double B = 0.91;

        /// <summary>
        /// 
        /// </summary>
        private double E
        {
            get
            {
                return B * 0.01 * CocomoIIScaleItems.Sum(x => x.SelectedItem);
            }
            set { }
        }

        /// <summary>
        /// 
        /// </summary>
        public double PM
        {
            get
            {
                double EAF = 1;
                foreach (var value in CocomoIIPAItems)
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
                double PMs = 1;
                for (int i = 0; i < CocomoIIPAItems.Count() - 1; i++)
                    PMs *= CocomoIIPAItems[i].SelectedItem;

                double power = 0.28 + 0.2 * E - B;

                return CocomoIIPAItems.LastOrDefault().SelectedItem * 3.67 * Math.Pow(PMs, power); 
            }
            set { }
        }

        /// <summary>
        /// количество строк кода
        /// </summary>
        public long Size { get; set; }
    }
}