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

        List<Work> workList = new List<Work>();
        DriverList driverList = new DriverList("drivers.txt"); //!
        RouteList routeList = new RouteList("routes.txt"); //!

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
        public void Add()
        {
            try
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
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void Show()
        {
            foreach (Work work in workList)
                Console.WriteLine(work.ToString());
        }

        public void WriteReportInFile(string fileName)
        {
            using (StreamWriter sw = new StreamWriter(fileName, false, System.Text.Encoding.Default)) //можно изменить место записи
            {
                try
                {
                    foreach (Work work in workList)
                    {
                        //to File - чтобы заново считать
                        //to String (неправильно конечно) - чтобы читабельно было, в отчет пишу так
                        sw.WriteLine(work.ToString());
                    }
                    Console.WriteLine("Отчет сохранен в " + fileName + "\n");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

            }
        }
        
        public void LoadFromFile (string fileName)
        {
            try
            {
                StreamReader file = new StreamReader(fileName, System.Text.Encoding.Default);
                while ((line = file.ReadLine()) != null)
                {
                    string[] strSplit = line.Split(' ');
                    workList.Add(new Work(
                        routeList.getByIndex(Convert.ToInt32(strSplit[0])),
                        driverList.getByIndex(Convert.ToInt32(strSplit[1])),
                        Convert.ToDateTime(Convert.ToDateTime(strSplit[2])),
                        Convert.ToDateTime(Convert.ToDateTime(strSplit[3]))));
                }
                file.Close();
                counter = workList.Count;
            }catch(Exception e)
            {
                Console.WriteLine(e);
            }

        }

        public void SaveToFile()
        {
            string fileName = "workList.txt";
            using (StreamWriter sw = new StreamWriter(fileName, false, System.Text.Encoding.Default)) //можно изменить место записи
            {
                try
                {
                    foreach (Work work in workList)
                    {
                        //to File - чтобы заново считать
                        sw.WriteLine(work.ToFile());
                    }
                    sw.Close();
                    Console.WriteLine("Отчет сохранен в " + fileName + "\n");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

            }
        }

    }
}
