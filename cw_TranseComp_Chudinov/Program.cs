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
            while(flag)
            {
                Console.WriteLine("Для дальшейшей работы выберите пункт:" +
                    "\n1 - " +
                    "\n2 - " +
                    "\n3 - " +
                    "\n4 - " +
                    "\n5 - " +
                    "\n6 - " +
                    "\n7 - " +
                    "\n8 - " +
                    "\n9 - " +
                    "\nЛюбое другое число - выход"
                    );
                string choose_menu = Console.ReadLine();
                if (!Int32.TryParse(choose_menu, out x))
                {
                    Console.WriteLine("Некорректный ввод! Повторите ввод");
                }
                else
                {
                    switch(x)
                    {
                      
                    }

                }


            }
            Console.ReadKey();
            
        }
        
    }

    
}
