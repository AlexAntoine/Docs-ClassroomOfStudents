using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomFullOfStudents
{
    class MissAnnSchoolOfDance : Students
    {
        private String _danceInstructor;
        private double _shoeSize;
        private String _danceStyle;

        public MissAnnSchoolOfDance()
        {

        }

        public bool setDanceInstructor(string s)
        {
            _danceInstructor = s;
            return true;
        }

        public String getDanceInstructor()
        {
            return _danceInstructor;
        }

        public bool setDanceStyle(string s)
        {
            _danceStyle = s;
            return true;
        }

        public String getDanceStyle()
        {
            return _danceStyle; 
        }

        public bool setShoeSize(string s)
        {
            try
            {
                _shoeSize = Convert.ToInt32(s);
                    return true;
            }
            catch
            {
                return false;
            }
        }

        public double getShoeSize()
        {
            return _shoeSize;
        }
    }
}