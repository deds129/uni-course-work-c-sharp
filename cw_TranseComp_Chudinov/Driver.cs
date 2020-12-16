using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_TranseComp_Chudinov
{
    class Driver
    {
        private string surname;
        private string name;
        private string secondname;
        private int experience;
        static int ID = 0;
        int id;

        public string FullName
        {
            get
            {
                return surname+ " " + name + " " + secondname;
            }
        }

        public Driver(string surname, string name, string secondname, int experience)
        {
            this.surname = surname;
            this.name = name;
            this.secondname = secondname;
            if (experience < 0)
                this.experience = 0;
            else
                this.experience = experience;
            ID++;
            id = ID;
        }

        public int Id
        {
            get { return id; }
        }

        public override string ToString()
        {
            return "ФИО водителя: " + surname + " " +
                  name + " " + secondname + ", стаж: " + experience;
        }

        public string ToFile()
        {
            return surname +
                " " + name + " " + secondname + " " + experience;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
