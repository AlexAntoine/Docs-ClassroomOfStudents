using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomFullOfStudents
{
    class IO
    {
        public IO()
        {

        }

        public void writeSomething(String temp)
        {
            Console.WriteLine(temp);

        }

        public String getDataFromUser(String userMessage)
        {
            Console.Write(userMessage + " ");
            return Console.ReadLine();
        }
    }
}
