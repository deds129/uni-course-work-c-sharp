using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_TranseComp_Chudinov
{
    class Route
    {
        private string routeName;
        private int range;
        private int daysOnWay;
        private int payment;

        public Route(string routeName, int range, int daysOnWay, int payment)
        {
            this.routeName = routeName;
            this.range = range;
            this.daysOnWay = daysOnWay;
            this.payment = payment;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return "Название маршрута: " + routeName + ", дальность = " + range +
                ", время маршрута = " + daysOnWay + ", оплата = " + payment;
        }

        public string ToFile()
        {
            return routeName + " " + range +
                " " + daysOnWay + " " + payment;
        }
    }
}
