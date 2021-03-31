using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomFullOfStudents
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            CurryStudents cs = new CurryStudents();
            NurseyStudents nursery = new NurseyStudents();
            MissAnnSchoolOfDance dances = new MissAnnSchoolOfDance();
            SoccerPlayer soccer = new SoccerPlayer();

            CurryStudents[] csa = new CurryStudents[7];

            for(int n = 0; n < csa.Length; n++)
            {
                Console.WriteLine("What is your first name");
                while(!csa[n].setFName(Console.ReadLine()));

                Console.WriteLine("What is your last name");
                while (!csa[n].setFName(Console.ReadLine()));

                Console.WriteLine("What is the gender of the student");
                while (!csa[n].setGender(Console.ReadLine()));

                Console.WriteLine("what is the student's major");
                while (!csa[n].setMajor(Console.ReadLine()));

            }

            NurseyStudents[] nurse = new NurseyStudents[4];

            for(int n = 0; n < nurse.Length; n++)
            {
                Console.WriteLine("what is the students first name");
                while (!nurse[n].setFName(Console.ReadLine()));

                Console.WriteLine("what is the Student's last name?");
                while (!nurse[n].setLName(Console.ReadLine()));

                Console.WriteLine("what is the student's phone number?");
                while (!nurse[n].setPhoneNumber(Console.ReadLine()));

                Console.WriteLine("What is the student's reading level?");
                while (!nurse[n].setReadingLevel(Console.ReadLine()));

                Console.WriteLine("what is the student allergice to?");
                while (!nurse[n].setAllergies(Console.ReadLine()));
            }

            MissAnnSchoolOfDance[] dance = new MissAnnSchoolOfDance[3];

            for(int n = 0; n < dance.Length; n++)
            {
                Console.WriteLine("what is the students first name");
                while (!dance[n].setFName(Console.ReadLine())) ;

                Console.WriteLine("what is the Student's last name?");
                while (!dance[n].setLName(Console.ReadLine())) ;

                Console.WriteLine("what is the student's shoe size");
                while (!dance[n].setShoeSize(Console.ReadLine())) ;

                Console.WriteLine("What is the student's danceStyle?");
                while (!dance[n].setDanceStyle(Console.ReadLine())) ;

            }

            SoccerPlayer[] players = new SoccerPlayer[4];

            for(int n = 0; n < players.Length; n++)
            {
                Console.WriteLine("what are the positions the player has played");
                while (players[n].setPositionPlayed(Console.ReadLine())) ;

                Console.WriteLine("how many goals did the player scored?");
                while (!players[n].setGoalsScored(Console.ReadLine())) ;

                Console.WriteLine("what is the player's jersey number?");
                while (!players[n].setJerseyNumbers(Console.ReadLine())) ;

                Console.WriteLine("What is the player's ranking?");
                while (!players[n].setRanking(Console.ReadLine())) ;

                Console.WriteLine("what is the player's phone numnber?");
                while (!players[n].setPhoneNumber(Console.ReadLine())) ;
            }

           
        }
    }
}
