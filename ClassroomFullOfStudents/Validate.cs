using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomFullOfStudents
{
    class Validate
    {
        public Validate()
        {

        }

        public bool validateNumber(String s, int a)
        {
            try
            {
                Convert.ToInt32(s);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool validateNumber(String s, double b)
        {
            try
            {
                Convert.ToDouble(s);
                return true;
            }
            catch
            {
                return false; 
            }
        }
    }
}
