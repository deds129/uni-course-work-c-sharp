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
            bool flag = true;
            Console.WriteLine("\t============================================================================");
            Console.WriteLine("\t========Добро пожаловать в систему управлением Грузовыми Перевозками========");
            Console.WriteLine("\t============================================================================");

            DriverList driverList = new DriverList("drivers.txt");
            RouteList routeList = new RouteList("routes.txt");
             WorkList workList = new WorkList(0);

            Console.WriteLine("Списки:");
           // driverList.ShowList();
           // Console.WriteLine();
          //  routeList.ShowList();


           // Console.WriteLine();
           // Console.WriteLine("Пожалуйста Введите кол-во доставок(работ) для назнеачения работ: ");
           //int workCount = Convert.ToInt32(Console.ReadLine());
            while (flag)
            {
                Console.WriteLine("Для дальшейшей работы выберите пункт:" +
                  //  "\n ---Водители---" +
                    "\n1 - Вывести список водителей" +
                    "\n2 - Сохранить список водителей в новый файл" +
                    "\n3 - Добавить нового водителя в список (с сохранением в файл)" +
                 //   "\n ---Маршруты---" +
                    "\n4 - Вывести список маршрутов " +
                    "\n5 - Сохранить список маршрутов в новый файл" +
                    "\n6 - Добавить новый маршрут в список (с сохранением в файл)" +
                  //  "\n - список работ"
                    "\n7 - Назначить работу" +
                    "\n8 - Вывести список назначенных работ" +
                    "\n9 - Создать отчетный файл со списком работ" + //супер идея - надежная ***** как швейцарские часы
                    "\n10 - Сохранить информацию о работах в файл(с возможностью загружения из файла) - пока не работет"+
                    "\n11 - Загрузиться с файла(заполнить лист значениями из файла)"+
                    "\nЛюбое другое число - выход\n"
                    );
                string choose_menu = Console.ReadLine();
                if (!Int32.TryParse(choose_menu, out x))
                {
                    Console.WriteLine("Некорректный ввод! Повторите ввод\n");
                }
                else
                {
                    switch (x)
                    {
                        case 1:
                            driverList.ShowList();
                            Console.WriteLine("\n");
                            break;
                        case 2:
                            Console.WriteLine("Введите название файла и путь: ");
                            s = Console.ReadLine();
                            driverList.writeListInFile(s);
                            break;
                        case 3:
                            driverList.AddNewMemberAndSave();
                            break;

                        case 4:
                            routeList.ShowList();
                            Console.WriteLine("\n");
                            break;
                        case 5:
                            Console.WriteLine("Введите название файла и путь: ");
                             s = Console.ReadLine();
                            break;
                        case 6:
                            routeList.AddNewMemberAndSave();
                            break;
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
                            workList.SaveToFile();
                            break;
                        case 10:
                            workList.SaveToFile();
                            break;
                        case 11:
                            string fileName = "workList.txt"; //расширить можно загрузка из разных файлов
                            workList.LoadFromFile(fileName);
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
