using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomFullOfStudents
{
    class SoccerPlayer : Students
    {
        private String _positionPlayed;
        private int _goalsScored;
        private int _jerseyNumber;
        private int _ranking;
        private int _phoneNumber;

        public SoccerPlayer()
        {

        }

        public bool setPositionPlayed(string s)
        {
            if (s.Equals("forward") || s.Equals("middle") || s.Equals("back") || s.Equals("goal"))

             _positionPlayed = s;

            return true;
        }

        public String getPositionPlayed()
        {
            return _positionPlayed;
        }

        public bool setGoalsScored(string s)
        {
            try
            {
                _goalsScored = Convert.ToInt32(s);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int getGoalsScored()
        {
            return _goalsScored;
        }

        public bool setJerseyNumbers(string s)
        {
            try
            {
                _jerseyNumber = Convert.ToInt32(s);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int getJerseyNumbers()
        {
            return _jerseyNumber;
        }

        public bool setRanking(string s)
        {
            try
            { 
                _ranking = Convert.ToInt32(s);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int getRanking()
        {
            return _ranking;
        }

        public bool setPhoneNumber(string s)
        {
            try
            {
                if (s.Length != 10)
                    return false;

                _phoneNumber = Convert.ToInt32(s);
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

        public override bool setAge(string s)
        {
            return base.setAge(s);
        }
    }
}