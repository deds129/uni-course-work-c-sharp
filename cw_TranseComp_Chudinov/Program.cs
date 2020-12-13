using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_TranseComp_Chudinov
{
    class Program
    {
        static void Main(string[] args)
        {
            DriverList driverList = new DriverList("drivers.txt");
            driverList.ShowList();

            Console.WriteLine();

            RouteList routeList = new RouteList("routes.txt");
            routeList.ShowList();

            routeList.writeListInFile("routes.txt");
            Console.ReadKey();
           
        }
        
    }

    
}
