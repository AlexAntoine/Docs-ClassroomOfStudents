using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomFullOfStudents
{
    class NurseyStudents : Students
    {
        private double _readingLevel;
        private double _phoneNumber;
        private String _allergies;

        public NurseyStudents()
        {

        }

        public bool setAllergies(string s)
        {
            _allergies = s;
            return true;
        }

        public String getAllergies()
        {
            return _allergies;
        }

        public bool setPhoneNumber(string s)
        {
            try
            {
                if (s.Length != 10)
                    return false;

                _phoneNumber = Convert.ToDouble(s);
                return true;

            }
            catch
            {
                return false;
            }

        }

        public String getPhoneNumber()
        {
            return _phoneNumber.ToString();
        }

        public bool setReadingLevel(String s)
        {
            try
            {
                _readingLevel = Convert.ToDouble(s);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public double getReadingLevel()
        {
            return _readingLevel;
        }
    }
}