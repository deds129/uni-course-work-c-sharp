using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_TranseComp_Chudinov
{
    class DriverList
    {
        int counter = 0;
        string line;
        List<Driver> drivers = new List<Driver>();
      
        public DriverList(string fileName)
        {
            try
            {
                StreamReader file = new StreamReader(fileName, System.Text.Encoding.Default);
                while ((line = file.ReadLine()) != null)
                {
                    string[] strSplit = line.Split(' ');
                    drivers.Add(new Driver(
                        strSplit[0].ToString(),
                        strSplit[1].ToString(),
                        strSplit[2].ToString(),
                        Convert.ToInt32(strSplit[3])));
                }
                file.Close();
                counter = drivers.Count;
            }
            
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
        }

        public DriverList(int listSize)
        {
            try
            {
                string newSurname;
                string newName;
                string newSecondname;
                int newExperience;
                for (int i = 0; i < listSize; i++)
                {
                    Console.WriteLine($"Введите данные водителя №{i + 1}");
                    Console.Write("Фамилия: ");
                    newSurname = Convert.ToString(Console.ReadLine());
                    Console.Write("Имя: ");
                    newName = Convert.ToString(Console.ReadLine());
                    Console.Write("Отчество: ");
                    newSecondname = Convert.ToString(Console.ReadLine());
                    Console.Write("Стаж: ");
                    newExperience = Convert.ToInt32(Console.ReadLine());
                    if (newExperience < 0)
                        throw new Exception();
                    Console.WriteLine();

                    drivers.Add(new Driver(
                        newSurname,
                        newName,
                        newSecondname,
                        newExperience));
                }
                writeListInFile("drivers.txt");
                counter = drivers.Count;
            }
            catch
            {
                Console.WriteLine("Ошибка ввода!");
            }
        }

        public void ShowList()
        {
            Console.WriteLine("-----Список водителей----- ");
            foreach(Driver driver in drivers)
            {
                Console.WriteLine(driver.ToString());
            }
        }

        public void AddNewMemberAndSave()
        {
            try
            {
                string newSurname;
                string newName;
                string newSecondname;
                int newExperience;
                Console.WriteLine($"Введите данные водителя: ");
                Console.Write("Фамилия: ");
                newSurname = Convert.ToString(Console.ReadLine());
                Console.Write("Имя: ");
                newName = Convert.ToString(Console.ReadLine());
                Console.Write("Отчество: ");
                newSecondname = Convert.ToString(Console.ReadLine());
                Console.Write("Стаж: ");
                newExperience = Convert.ToInt32(Console.ReadLine());
                if (newExperience < 0)
                    throw new Exception();
                Console.WriteLine();

                drivers.Add(new Driver(
                    newSurname,
                    newName,
                    newSecondname,
                    newExperience));
                writeListInFile("drivers.txt");
            }
            catch
            {
                Console.WriteLine("Ошибка при добавлении пользователя! Возможно вы ввели некорректные данные!");
            }
        }

        public void RemoveMember(int i)
        {
            try
            {
                drivers.Remove(drivers[i]);
                writeListInFile("drivers.txt");
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public Driver getByIndex(int i)
        {
            return drivers[i];
        }

        public void writeListInFile(string fileName)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(fileName, false, System.Text.Encoding.Default)) //можно изменить место записи
                {
                    foreach (Driver driver in drivers)
                    {
                        sw.WriteLine(driver.ToFile());
                    }
                    sw.Close();
                    Console.WriteLine("Данные записаны в " + fileName);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
    }
}
