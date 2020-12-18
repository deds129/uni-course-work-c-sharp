using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_TranseComp_Chudinov
{
    class Work
    {
        private Route route;
        private Driver driver;
        private DateTime dispDate;
        private DateTime arrivalDate;
        private int award;

        public Work(Route route, Driver driver, DateTime dispDate, DateTime arrivalDate)
        {
            this.route = route;
            this.driver = driver;
            this.dispDate = dispDate;
            this.arrivalDate = arrivalDate;
        }

        public override string ToString()
        {
            return   "Маршрут: " + route.RouteName + " ФИО Водителя: " +
                driver.FullName + " Дата отправки : " + dispDate.ToString("dd.MM.yyyy") +
                 " Дата возвращения : " + arrivalDate.ToString("dd.MM.yyyy");
          
        }

        //переделать
        public string ToFile()
        {
            return route.Id + " " + driver.Id + " " + arrivalDate.ToString("dd.MM.yyyy") + " " + dispDate.ToString("dd.MM.yyyy");    
        }
        
       

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
