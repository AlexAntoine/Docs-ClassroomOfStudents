using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomFullOfStudents
{
    class Dates
    {
        private int _day;
        private int _month;
        private int _year;

        public Dates()
        {
            DateTime date = DateTime.Now;
        }

        public bool setday(string s)
        {
            if (s.Length == 2)
                return false;

            if (s[0] == 0 && s[1] == 0)
                return false;

            if (s[0] == 3 && s[1] > 1)
                return false;

            if (s[0] < 0 || s[1] > 9)
                return false;

            _day = Convert.ToInt32(s);

            return true;
        }

        public int getDay()
        {
            return _day;
        }

        public bool setMonth(string s)
        {
            s.ToLower();

            if(s.Equals("jan") || s.Equals("january"))
            {
                _month = Convert.ToInt32(s);
                _month = 1;

                return true;
            }

            if (s.Equals("feb") || s.Equals("febuary"))
            {
                _month = Convert.ToInt32(s);
                _month = 2;

                return true;
            }
            
            if(s.Equals("mar") || s.Equals("march"))
            {
                _month = Convert.ToInt32(s);
                _month = 3;

                return true;
            }

            if (s.Equals("apr") || s.Equals("april"))
            {
                _month = Convert.ToInt32(s);
                _month = 4;

                return true;
            }

            if (s.Equals("may"))
            {
                _month = Convert.ToInt32(s);
                _month = 5;

                return true;
            }

            if (s.Equals("jun") || s.Equals("june"))
            {
                _month = Convert.ToInt32(s);
                _month = 6;

                return true;
            }

            if (s.Equals("jul") || s.Equals("july"))
            {
                _month = Convert.ToInt32(s);
                _month = 7;

                return true;
            }

            if (s.Equals("aug") || s.Equals("august"))
            {
                _month = Convert.ToInt32(s);
                _month = 8;

                return true;
            }

            if (s.Equals("sept") || s.Equals("september"))
            {
                _month = Convert.ToInt32(s);
                _month = 9;

                return true;
            }

            if (s.Equals("oct") || s.Equals("october"))
            {
                _month = Convert.ToInt32(s);
                _month = 10;

                return true;
            }

            if (s.Equals("nov") || s.Equals("november"))
            {
                _month = Convert.ToInt32(s);
                _month = 11;

                return true;
            }

            if (s.Equals("dec") || s.Equals("december"))
            {
                _month = Convert.ToInt32(s);
                _month = 12;

                return true;
            }

            return false;
        }

        public int getMonth()
        {
            return _month;
        }

        public bool setYear(string s)
        {
            if (s[0] == 1 && s[1] < 9)
                return false;

            if (s[0] == 2 && s[1] != 0)
                return false;
            else
            {
                _year = Convert.ToInt32(s);
                return true;
            }
            
        }

        public int getYear()
        {
            return _year;
        }

        public void calculatingAge()
        {
            int age;
            DateTime date = DateTime.Now;

            age = date.Year - _year;

            if (date.Month > _month)
                age = age - 1;

            if (date.Month < _month)
                age = age - 0;

            if(date.Month == _month)
            {
                if (date.Day > _day)
                    age = age - 1;

                else if (date.Day <= _day)
                    age = age - 0;
            }
        }
    }
}