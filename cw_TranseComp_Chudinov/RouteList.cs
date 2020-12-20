using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_TranseComp_Chudinov
{
    class RouteList
    {
        int counter = 0;
        string line;
        List<Route> routes = new List<Route>();

        public RouteList(string fileName)
        {
            try
            {
                StreamReader file = new StreamReader(fileName, System.Text.Encoding.Default);
                while ((line = file.ReadLine()) != null)
                {
                    string[] strSplit = line.Split(' ');
                    routes.Add(new Route(
                        strSplit[0].ToString(), //routeName
                        Convert.ToInt32(strSplit[1]), //range
                        Convert.ToInt32(strSplit[2]), //daysOnWay
                        Convert.ToInt32(strSplit[3]))); //payment
                }
                file.Close();
                counter = routes.Count;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

        //чтение с консоли
        public RouteList(int listSize)
        {
            try
            {
                  string newRouteName;
                  int newRange;
                  int newDaysOnWay;
                  int newPayment;
                for (int i = 0; i < listSize; i++)
                {
                    Console.WriteLine($"Введите данные Маршрута №{i + 1}");
                    Console.Write("Название маршрута: ");
                    newRouteName = Convert.ToString(Console.ReadLine());
                    

                    Console.Write("Дальность: ");
                    newRange = Convert.ToInt32(Console.ReadLine());
                    if (newRange < 0)
                        throw new Exception();

                    Console.Write("Кол-во дней в пути: ");
                    newDaysOnWay = Convert.ToInt32(Console.ReadLine());
                    if (newDaysOnWay < 0)
                        throw new Exception();

                    Console.Write("Оплата: ");
                    newPayment = Convert.ToInt32(Console.ReadLine());
                    if (newPayment < 0)
                        throw new Exception();
                    Console.WriteLine();

                   routes.Add(new Route(
                        newRouteName,
                        newRange,
                        newDaysOnWay,
                        newPayment));
                }
                counter = routes.Count;
            }
            catch
            {
                Console.WriteLine("Ошибка ввода!");
            }
        }

        public void ShowList()
        {
            Console.WriteLine("-----Список маршрутов----- ");
            foreach (Route route in routes)
            {
                Console.WriteLine(route.ToString());
            }
        }

        public void writeListInFile(string fileName)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(fileName, false, System.Text.Encoding.Default)) //можно изменить место записи
                {
                    foreach (Route route in routes)
                    {
                        sw.WriteLine(route.ToFile());
                    }
                    sw.Close();
                }
                Console.WriteLine("Данные записаны в " +  fileName);
            }
            catch
            {
                Console.WriteLine("Oшибка записи в файл!");
            }
        }
        public Route getByIndex(int i)
        {
            return routes[i];
        }

        //возможно нужно будет переделать
        public void AddNewMemberAndSave()
        {
            try
            {
                string newRouteName;
                int newRange;
                int newDaysOnWay;
                int newPayment;

                Console.WriteLine($"Введите данные Маршрута");
                Console.Write("Название маршрута: ");
                newRouteName = Convert.ToString(Console.ReadLine());


                Console.Write("Дальность: ");
                newRange = Convert.ToInt32(Console.ReadLine());
                if (newRange < 0)
                    throw new Exception();

                Console.Write("Кол-во дней в пути: ");
                newDaysOnWay = Convert.ToInt32(Console.ReadLine());
                if (newDaysOnWay < 0)
                    throw new Exception();

                Console.Write("Оплата: ");
                newPayment = Convert.ToInt32(Console.ReadLine());
                if (newPayment < 0)
                    throw new Exception();
                Console.WriteLine();

                routes.Add(new Route(
                     newRouteName,
                     newRange,
                     newDaysOnWay,
                     newPayment));
                writeListInFile("routes.txt");
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void RemoveMember(int i)
        {
            try
            {
                routes.Remove(routes[i]);
                writeListInFile("routes.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
