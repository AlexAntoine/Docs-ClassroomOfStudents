using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomFullOfStudents
{
    class Students
    {
        private String _fName;
        private String _lName;
        protected String _iD;
        protected int _age;
        private char _gender;
        private String _password;
        private Address _residence; //composition
        private Dates _birthdate; //composition

        public Students()
        {

        }

        public bool setFName(string s)
        {
            _fName = s;
            return true;
        }

        public String getFName()
        {
            return _fName;
        }

        public bool setLName(string s)
        {
            _lName = s;
            return true;
        }

        public String getLName()
        {
            return _lName;
        }

        public bool setId(string s)
        { 
            if(_password.Equals(_password))
            {
                if (s.Length != 10)
                    return false;

                if (s[0] != '@')
                    return false;

                String temp = s.Substring(1);

                try
                {
                    if (Convert.ToInt32(temp) < 0)
                        return false;
                }
                catch
                {
                    return false;

                }
            }
            _iD = s;
            return true;
        }

        public String getId(String pw)
        {
            if(pw.Equals(_password))
            return _iD;
            else
                return "Your are not permitted. ";
        }

        public virtual bool setAge(string s)
        {
            try
            {
                if (Convert.ToInt16(s) > -1)
                {
                    _age = Convert.ToInt32(s);
                    return true;
                }

                return false;
            }
            catch
            {
                return false;
            }
        }

        public int getAge()
        {
            return _age;
        }

        public bool setGender(string s)
        {
            if(s.Equals("male") || s.Equals("man") || s.Equals("boy") || s.Equals("dude"))
            {
                _gender = 'm';
                return true;
            }

            if(s.Equals("female") || s.Equals("woman") || s.Equals("girl") || s.Equals("dudette"))
            {
                _gender = 'f';
                return true;
            }

            _gender = 'x';
            return false;

        }

        public String getGender()
        {
            if (_gender == 'm')
                return "male";
            if (_gender == 'f')
                return "female";

            return "gender not initalized";
        }

        public bool setPassword(string pw, String newPassword)
        {
            if(pw == _password)
            {
                _password = newPassword;
                return true;
            }
            return false;
        }

        public Dates setBirthDate()
        {
            return _birthdate;
        }


    }
}