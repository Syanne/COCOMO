using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cocomo.Models
{
    public class ResultModel
    {
        public string Name { get; set; }
        public double TM { get; set; }
        public double PM { get; set; }

        public ResultModel(string name, double tm, double pm)
        {
            this.Name = name;
            this.PM = pm;
            this.TM = tm;
        }
    }
}