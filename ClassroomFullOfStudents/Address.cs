using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomFullOfStudents
{
     class Address
    {
        private String _street;
        private int _number;
        private String _city;
        private String _state;
        private int _zip;
       
        public Address()
        {

        }

        public bool setStreet(string s)
        {
            _street = s;
            return true;
        }

        public String getStreet()
        {
            return _street;
        }

        public bool setNumber(string s)
        {
            try
            {
                _number = Convert.ToInt32(s);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int getNumber()
        {
            return _number;
        }

        public bool setState(string s)
        {
            _state = s;
            return true;
        }

        public String getState()
        {
            return _state;
        }

        public bool setCity(string s)
        {
            _city = s;
            return true;
        }

        public String getCity()
        {
            return _city;
        }

        public bool setZip(string s)
        {
            try
            {
                _zip = Convert.ToInt32(s);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int getZip()
        {
            return _zip;
        }

        
    }
}