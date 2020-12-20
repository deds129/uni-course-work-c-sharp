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
            string s;
            int a;
            bool flag = true;
            Console.WriteLine("\t============================================================================");
            Console.WriteLine("\t========Добро пожаловать в систему управлением Грузовыми Перевозками========");
            Console.WriteLine("\t============================================================================");

            // DriverList driverList = new DriverList("drivers.txt");
            // RouteList routeList = new RouteList("routes.txt");
            DriverList driverList = new DriverList(0);
            RouteList routeList = new RouteList(0);
            WorkList workList = new WorkList(0);
          

            

           
            while (flag)
            {
                Console.WriteLine("Для дальшейшей работы выберите пункт:\n" +
                    "\n ------------ВОДИТЕЛИ------------" +
                    "\n1 - Вывести список водителей в косоль" +
                    "\n2 - Cоздать новый список водителей c консоли с сохранением в файл" +
                    "\n3 - Сохранить список водителей в новый файл" +
                    "\n4 - Добавить нового водителя в список (с сохранением в файл)" +
                    "\n5 - Удалить водителя из списока (с сохранением в файл)" +
                    "\n6 - Загрузить список водителей с хранилища" +

                    "\n\n ------------МАРШРУТЫ------------" +
                    "\n4 - Вывести список маршрутов " +
                    "\n5 - Сохранить список маршрутов в новый файл" +
                    "\n6 - Добавить новый маршрут в список (с сохранением в файл)" +

                    "\n\n ------------ЗАКАЗЫ------------" +
                    "\n7 - Добавить новый заказ" +
                    "\n8 - Вывести список назначенных заказов" +
                    "\n10 - Сохранить информацию о работах в файл(с возможностью загружения из файла) - пока не работет" +
                    "\n11 - Загрузиться с файла(заполнить лист значениями из файла)" +

                    "\n\n ------------ОТЧЕТЫ ПО ВЫПЛАТАМ------------" +
                    "\n9 - Создать отчет с расчетом расходов на выплату зарплат" +
                    "\n12 - " +
                "\nЛюбое другое число - выход\n");
                string choose_menu = Console.ReadLine();
                if (!Int32.TryParse(choose_menu, out x))
                {
                    Console.WriteLine("Некорректный ввод! Повторите ввод\n");
                }
                else
                {
                    switch (x)
                    {
                        // "\n ------------ВОДИТЕЛИ------------" +

                        // "\n1 - Вывести список водителей" +
                        case 1:
                            driverList.ShowList();
                            Console.WriteLine("\n");
                            break;
                        
                        case 2:
                            Console.WriteLine("Введите размерность списка: ");
                            a = Convert.ToInt32(Console.ReadLine());
                            driverList = new DriverList(a);
                            break;

                        case 3:
                            Console.WriteLine("Введите название файла и путь: ");
                            s = Console.ReadLine();
                            driverList.writeListInFile(s);
                            break;
                           
                        case 4:
                            driverList.AddNewMemberAndSave();
                            break;
                        case 5:
                            Console.WriteLine("Введите id водителя: ");
                            a = Convert.ToInt32(Console.ReadLine());
                            driverList.RemoveMember(a);
                            break;
                        case 6:
                            driverList = new DriverList("drivers.txt");
                            break;

                            // МАРШРУТЫ

                        // "\n4 - Вывести список маршрутов " +
                        case 4:
                            routeList.ShowList();
                            Console.WriteLine("\n");
                            break;
                        //"\n5 - Сохранить список маршрутов в новый файл" +
                        case 5:
                            Console.WriteLine("Введите название файла и путь: ");
                             s = Console.ReadLine();
                            break;
                        //"\n6 - Добавить новый маршрут в список (с сохранением в файл)" +
                        case 6:
                            routeList.AddNewMemberAndSave();
                            break;
                        //"\n\n ------------ЗАКАЗЫ------------" +
                        case 7:
                            workList.Add();
                            break;
                        case 8:
                            Console.WriteLine("-----Cписок назначенных работ-----");
                            workList.Show();
                            Console.WriteLine();
                            break;
                        case 9:
                            //Сохранить сведения о работах в отчетный файл
                            workList.WriteReportInFile("Отчет_по_выплатам.txt");
                            break;
                        case 10:
                            workList.SaveToFile();
                            break;
                        case 11:
                            string fileName = "workList.txt"; //расширить можно загрузка из разных файлов
                            workList.LoadFromFile(fileName);
                            break;
                        case 12:

                            break;
                        default:
                            flag = false;
                            break;
                    }

                }
   
            }
            Console.ReadKey();
            

        }
        
    }

    
}
