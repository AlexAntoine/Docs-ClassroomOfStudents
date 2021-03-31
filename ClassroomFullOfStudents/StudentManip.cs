using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomFullOfStudents
{
    class StudentManip
    {
      
        private Students[] roster;
        private NurseyStudents[] nurse;
        private MissAnnSchoolOfDance[] dance;
        private SoccerPlayer[] soccer;
        private CurryStudents[] curry;


        public StudentManip(String fName, String lName, String gender, String iD)
        {
            Validate valid = new Validate();
            DateTime date = DateTime.Now;

            String userInput;
            String menu = "";
            int upperInputValue = 4;
            IO inOut = new IO();

            menu += "OOP Student Classroom Roster\n";
            menu += "\n0 - exit";
            menu += "\n1 - add a student";
            menu += "\n2 - display all students";

            do
            {
                do
                {
                    userInput = inOut.getDataFromUser(menu);
                } while (userInput[0] < '0' || userInput[0] > '9' || userInput.Length != 1
                  || Convert.ToInt16(userInput) > upperInputValue);

                switch (userInput[0])
                {
                    case '0':
                        System.Environment.Exit(0);
                        break;
                    case '1':
                       if(!addStudent());
                        inOut.writeSomething("class full");
                        break;
                    case '2':
                        displayAllStudents(inOut);
                        break;


                }

            } while (true);

        }

        private void createOOPStudentArray(IO inOut, Validate valid)
        {
            //ask the user of number of students for in each school 
            //validate user input
            //create an array for each school
   
        }

        private bool initializeStudent(Students stu)
        {
            IO inOut = new IO();

            while (!stu.setFName(inOut.getDataFromUser("what is this student's first name?"))) ;

            while (!stu.setLName(inOut.getDataFromUser("what is this student's last name?"))) ;

            try
            {
                if (!studentSetID(stu, inOut))
                    return false;
            }
            catch
            {
                
            }

            while (!stu.setAge(inOut.getDataFromUser("what is this student's age?"))) ;

            return true;
        }

        private bool studentSetID(Students stu, IO inOut)
        {
            const int inputTryLimit = 5;
            int inputTryNumber;
            String inputValue;
            String pw;

            inputTryNumber = 0;
            do
            {
                if (inputTryLimit < ++inputTryNumber)
                {
                    inOut.writeSomething("attempt limit exceeded!");
                    return false;
                }

                inputValue = inOut.getDataFromUser("what is this student's ID?  ");
                pw = inOut.getDataFromUser("what is the change ID password?  ");
            } while (!stu.setId(inputValue));

            return true;
        }

        private bool addStudent()
        {
            Students stu = new Students();
            NurseyStudents nurse = new NurseyStudents();
            SoccerPlayer players = new SoccerPlayer();
            MissAnnSchoolOfDance dance = new MissAnnSchoolOfDance();


            if (initializeStudent(stu))
            {
                int n = 0;
                Students placeHolder = roster[n];

                while (placeHolder != null)
                {
                    n++;
                    if (n == roster.Length)
                        return false;

                    placeHolder = roster[n];
                }

                roster[n] = stu;
                return true;
            }

            return false;
        }

        private void studentSetAge(Students stu, IO inOut)
        {
            while (!stu.setAge(inOut.getDataFromUser("what is the student's age"))) ; 
            
        }

        private void studentSetLastName(Students stu, IO inOut)
        {
            while (!stu.setLName(inOut.getDataFromUser("what is this student's last name?")));
        }                                                                                  

        private void studentSetFirstName(Students stu, IO inOut)
        {
            while (!stu.setFName(inOut.getDataFromUser("what is this student's first name?")));
        }

        private bool arrayIsEmpty()
        {
            for (int n = 0; n < roster.Length; n++)
                if (roster[n] != null)
                    return false;

            return true;
        }

        private String removeAStudent(IO inOut)
        {
            String studentToRemove;
            int numStudentsInClass = 0;

            for (int n = 0; n < roster.Length; n++)
                if (roster[n] != null)
                    numStudentsInClass++;

            if (numStudentsInClass == 0)
                return "cannot remove a student as there are no students in the course";

            studentToRemove = inOut.getDataFromUser(
                "Which student from this list do you want to remove\n"
                + makeListOfStudentsInTheCourse() + "\n");

            for (int n = 0; n < roster.Length; n++)
            {
                if (roster[n] != null && studentToRemove.Equals(roster[n].getFName()))
                {
                    roster[n] = null;
                    return studentToRemove + " has been removed";
                }
            }

            return studentToRemove + " is not in this course";
        }

        private String makeListOfStudentsInTheCourse()
        {
            String outputString = "";

            if (arrayIsEmpty())
                outputString = "the roster has no students\n";
            else
            {
                for (int n = 0; n < roster.Length; n++)
                {
                    if (roster[n] != null)
                        outputString += roster[n].getFName() + ", ";
                }
            }
            outputString = outputString.Substring(0, outputString.Length - 2);

            return outputString;

        }

        public void displayAllStudents(IO inOut)
        {
            inOut.writeSomething(makeListOfStudentsInTheCourse() + "\n");
        }
    }
}

