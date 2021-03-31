using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomFullOfStudents
{
   class CurryStudents : Students
    {
        private String _major;
        private Double _gpa;
        private String _dorm;
        private String _livingStatus;
        

        public CurryStudents()
        {

        }

        public bool setMajor(string s)
        {
            _major = s;
            return true;
        }

        public String getMajor()
        {
            return _major;
        }

        public bool setGpa(string s)
        {
           try
            {
                _gpa = Convert.ToDouble(s);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public double getGpa()
        {
            return _gpa;
        }


        public bool setDorm(string s)
        {
            _dorm = s;
            return true;
        }

        public String getDorm()
        {
            return _dorm;
        }

        new public bool setId(String s)
        {
            if (s[0] != 'D')
                return false;

            if (s.Length != 9)
                return false;

            try
            {
                String temp = s.Substring(1);

                Convert.ToInt32(temp);
            } 
            catch
            {
                return false;
            }

             _iD = s;
            return true;
         
        }

        public String getId()
        {
            return _iD;
        }

        public bool setLivingStatus(string s)
        {
            _livingStatus = s;
            return true;
        }

        public String getLivingStatus()
        {
            return _livingStatus;
        }
    }
}