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
            
            int x;
            bool flag = true;
            Console.WriteLine("========Добро пожаловать в систему управлением Грузовыми Перевозками========");

            DriverList driverList = new DriverList("drivers.txt");
            RouteList routeList = new RouteList("routes.txt");
            WoksList workList = new WoksList("works.txt");
            
            while (flag)
            {
                Console.WriteLine("Для дальшейшей работы выберите пункт:" +
                    "\n1 - Вывести список водителей" +
                    "\n2 - Вывести список маршуртов" +
                    "\n3 - Вывести список работ" +
                    "\n4 - " +
                    "\n5 - " +
                    "\n6 - " +
                    "\n7 - " +
                    "\n8 - " +
                    "\n9 - " +
                    "\nЛюбое другое число - выход\n"
                    );
                string choose_menu = Console.ReadLine();
                if (!Int32.TryParse(choose_menu, out x))
                {
                    Console.WriteLine("Некорректный ввод! Повторите ввод");
                }
                else
                {
                    switch (x)
                    {
                        case 1:
                            driverList.ShowList();
                            break;
                        case 2:
                            routeList.ShowList();
                            break;
                        default:
                            flag = false;
                            break;
                    }

                }
                /*
                DateTime date = new DateTime(2000,10,10);
                Console.WriteLine(date.ToString("dd.MM.yyyy"));
                Console.ReadKey();
                */
            }
            
        }
        
    }

    
}
