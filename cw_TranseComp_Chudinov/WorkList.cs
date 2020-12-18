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

        static List<WorkList> workList = new List<WorkList>();

        public WorkList(string fileName)
        {
            try
            {
                StreamReader file = new StreamReader(fileName, System.Text.Encoding.Default);
                while ((line = file.ReadLine()) != null)
                {
                    string[] strSplit = line.Split(' ');
                    workList.Add(,,Convert.ToDateTime(strSplit[2]), Convert.ToDateTime(strSplit[2])
                }
            }
            catch
            {

            }
        }

        /*
        public WoksList(int listSize)
        {
            try
            {
                //найти в list 
            }
            catch
            {

            }
        }
        */


    }
}
