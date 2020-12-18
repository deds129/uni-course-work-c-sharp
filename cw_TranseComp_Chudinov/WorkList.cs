using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_TranseComp_Chudinov
{
    class WorkList
    {
        int counter = 0;
        string line;

        static List<Work> workList = new List<Work>();
        DriverList driverList = new DriverList("drivers.txt");
        RouteList routeList = new RouteList("routes.txt");

        public WorkList(int size)
        {
            for (int i = 0; i < size; i++)
            {

                Console.Write("Введите индекс водителя из списка: ");
                int dIndex = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите индекс маршрута из списка: ");
                int rIndex = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите дату отправки в формате dd.MM.yy");
                string aDate = Console.ReadLine();

                Console.WriteLine("Введите дату прибытия в формате dd.MM.yy");
                string dDate = Console.ReadLine();
                Console.WriteLine();
                workList.Add(new Work(
                    routeList.getByIndex(rIndex),
                    driverList.getByIndex(dIndex),
                    Convert.ToDateTime(aDate),
                    Convert.ToDateTime(dDate)));  
            }

        }
        public void Show()
        {
            foreach (Work work in workList )
                Console.WriteLine(work.ToString());
        }
    }
}
