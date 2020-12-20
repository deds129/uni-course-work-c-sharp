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
;
            DriverList driverList = new DriverList("drivers.txt");
            RouteList routeList = new RouteList("routes.txt");
            WorkList workList = new WorkList(0);
          

            

           
            while (flag)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Для дальшейшей работы выберите пункт:\n" +
                    "\n ------------ВОДИТЕЛИ------------" +
                    "\n1 - Вывести список водителей в консоль" +
                    "\n2 - Cоздать новый список водителей c консоли с сохранением в файл" +
                    "\n3 - Сохранить список водителей в новый файл" +
                    "\n4 - Добавить нового водителя в список (с сохранением в файл)" +
                    "\n5 - Удалить водителя из списка (с сохранением в файл)" +
                    "\n6 - Загрузить список водителей с хранилища");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n ------------МАРШРУТЫ------------" +
                    "\n7 - Вывести список маршрутов в консоль" +
                    "\n8 - Cоздать новый список маршрутов c консоли с сохранением в файл" +
                    "\n9 - Сохранить список маршрутов в новый файл" +
                    "\n10 - Добавить новый маршрут в список (с сохранением в файл)" +
                    "\n11 - Удалить маршрут из списка (с сохранением в файл)" +
                    "\n12 - Загрузить список маршрутов с хранилища");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(
                    "\n ------------ЗАКАЗЫ------------" +
                    "\n13 - Вывести список назначенных заказов" +
                    "\n14 - Сохранить информацию о работах в файл(с возможностью загружения из файла)" + //
                    "\n15 - Загрузить список работ с файла" +
                    "\n16 - Добавить новый заказ" +
                    "\n17 - Удалить заказ из списка");
                Console.ResetColor();
                Console.WriteLine(
                "\n\n ------------ОТЧЕТЫ ПО ВЫПЛАТАМ------------" +
                    "\n18 - Создать отчет с расчетом расходов на выплату зарплат" +
                "\nЛюбое другое число - выход\n");

                Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
                Console.Write("Введите пункт: ");
                Console.ResetColor();

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
                        case 7:
                            routeList.ShowList();
                            Console.WriteLine("\n");
                            break;

                        case 8:
                            Console.WriteLine("Введите размерность списка: ");
                            a = Convert.ToInt32(Console.ReadLine());
                            routeList = new RouteList(a);
                            break;

                        case 9:
                            Console.WriteLine("Введите название файла и путь: ");
                            s = Console.ReadLine();
                            routeList.writeListInFile(s);
                            break;

                        case 10:
                            routeList.AddNewMemberAndSave();
                            break;
                        case 11:
                            Console.WriteLine("Введите id маршрута: ");
                            a = Convert.ToInt32(Console.ReadLine());
                            routeList.RemoveMember(a);
                            break;
                        case 12:
                            routeList = new RouteList("routes.txt");
                            break;



                        //"\n\n ------------ЗАКАЗЫ------------" +
                        case 13:
                            Console.WriteLine("-----Cписок назначенных работ-----");
                            workList.Show();
                            Console.WriteLine();
                            break;

                        case 14:
                            workList.SaveToFile();
                            break;
                       
                            //??
                        case 15:
                            string fileName = "works.txt"; 
                            workList.LoadFromFile(fileName);
                            break;
                        
                        case 16:
                            workList.Add();
                            break;
                        case 17:
                            Console.WriteLine("Введите номер работы в списке: ");
                            a = Convert.ToInt32(Console.ReadLine());
                            workList.RemoveMember(a);
                            break;
                        //  "\n\n ------------ОТЧЕТЫ ПО ВЫПЛАТАМ------------" +

                        case 18:
                            //Сохранить сведения о работах в отчетный файл
                            workList.WriteReportInFile("Отчет_по_выплатам.txt");
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
