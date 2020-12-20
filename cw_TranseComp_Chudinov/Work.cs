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

        static int ID = 0;
        int id;

        public Work(Route route, Driver driver, DateTime dispDate, DateTime arrivalDate, int award)
        {
            this.route = route;
            this.driver = driver;
            if(dispDate.CompareTo(arrivalDate) <= 0)
            {
                this.dispDate = dispDate;
                this.arrivalDate = arrivalDate;
            }
            else
                throw new Exception("Неверно заданы даты!");
            if (award >= 0)
                this.award = award;
            else
                throw new Exception();
            id = ID++;
        }

        public int Id
        {
            get { return id; }
        }

        public int Award
        {
            get
            {
                return award;
            }
        }

        public override string ToString()
        {
            return  "id: "  + Id + " Маршрут: " + route.RouteName + " ФИО Водителя: " +
                driver.FullName + " Дата отправки : " + dispDate.ToString("dd.MM.yyyy") +
                 " Дата возвращения : " + arrivalDate.ToString("dd.MM.yyyy") + " премия: " + award;
          
        }

        public string ToFile()
        {
            return route.Id + " " + driver.Id + " " + arrivalDate.ToString("dd.MM.yyyy") + " " + dispDate.ToString("dd.MM.yyyy") + " " + award;    
        }
        
       

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public double getCashForWork()
        {
            return (award + (driver.Experience * route.Payment / 100.0) + route.Payment);
            
        }
    }
}
