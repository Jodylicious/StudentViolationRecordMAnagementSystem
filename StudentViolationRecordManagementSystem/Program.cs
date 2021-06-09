using System;
using System.Collections.Generic;

namespace StudentViolationRecordManagementStytem
{
    class User
    {
        public static void Homepage()     //USER'S MENU AFTER LOGIN
        {
            StudentRecord student = new StudentRecord();

            Console.WriteLine("\n\n***  WELCOME TO STUDENT VIOLATION RECORD MANAGEMENT SYSTEM ***");
            Console.WriteLine("1. View Student Record\n" +
                              "2. Student Entry\n" +
                              "3. Delete student profile \n" +
                              "4. Update student record\n" +
                              "5. Violation Reports\n" +
                              "6. Exit");
            Console.Write("\nChoose a number: ");
            var numChoice = Convert.ToInt32(Console.ReadLine());

            if (numChoice == 1)
            {
                student.ViewList();
            }
            else if (numChoice == 2)
            {
                student.StudentEntry();
            }
            else if (numChoice == 3)
            {
                student.DeleteRecord();
            }
            else if (numChoice == 4)
            {
                student.UpdateRecord();
            }
            else if (numChoice == 5)
            {
                student.Report();
            }
            else if (numChoice == 6)
            {
                student.Exit();
            }
            else
            {
                Console.Write(" Please enter an integer number. Thank you.\n");
                Homepage();
            }
        }
    }

    //
    public class StudEntry         //TO ACCESS INPUT VALUE FROM THE USER.
    {
        private string firstName;
        private string lastName;
        private int id;

        public StudEntry(int id, string firstName, string lastName)
        {
            this.id = id;
            this.lastName = lastName;
            this.firstName = firstName;
        }
        public int StudentNum
        {
            get { return id; }
            set { id = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

    }
    class StudentRecord      //VIEW LIST OF STUDENT RECORD
    {
        public void ViewList()
        {
            Console.WriteLine("\n\n-----Student Record List------\n");

            List<string> studentlist = new List<string>() { "Jodie Balaguer", "Michelle Ozoa", "McDale Organo", "Mark Acorda", "Clark Rayos" };

            foreach (var names in studentlist)
            {
                Console.WriteLine(names);
            }
            Exit();
        }

        public void StudentEntry()     // TO ADD STUDENT AND ITS VIOLATION
        {
            Console.WriteLine("\n\n-------STUDENT ENTRY----------");
            Console.Write("Enter Student Number: ");
            var id = Console.ReadLine();
            Console.Write("Student First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Student Last Name: ");
            string lastName = Console.ReadLine();


            Console.WriteLine("\nLIST OF VIOLATION: " +
                             "\na. ACADEMIC DISHONESTY ( Cheating, Plagiarism )" +
                             "\nb. ATTENDANCE AND PUNCTUALITY ( Late, Absence, Tardy )" +
                             "\nc. HARRASSMENT ( Bullying, Sexual Harrassment, Fighting)" +
                             "\nd. DAMAGE TO PROPERTY ( Vandalism )\n\n");

            Console.WriteLine("\n *** STUDENT ENTRY ***");
            Console.WriteLine("Student Number: {0}  \nStudent Name: {1} {2} \n", id, firstName, lastName);
            Console.Write("Choose letter of violation committed: ");
            string addchoice = Console.ReadLine();
            switch (addchoice)
            {
                case "a":
                    Console.WriteLine("Violation: ACADEMIC DISHONESTY"); break;
                case "b":
                    Console.WriteLine("Violation: ATTENDANCE AND PUNCTUALITY"); break;
                case "c":
                    Console.WriteLine("Violation: HARRASSMENT"); break;
                case "d":
                    Console.WriteLine("Violation: DAMAGE TO PROPERTY"); break;
                default:
                    Console.WriteLine("Invalid. Please try again.");
                    StudentEntry();
                    break;
            }

            Console.Write("\nDo you want to save this entry? ( y/n )   : ");
            string save = Console.ReadLine();
            if (save.Equals("y"))
            {
                Console.WriteLine("\nSuccessfully Added.\n");
            }
            else if (save.Equals("n"))
            {
                Console.WriteLine("\nCancelled.\n");
                User.Homepage();
            }
            else
            {
                Console.Write(" Invalid. ");
            }
            Exit();
        }

        public void DeleteRecord()      //DELETE STUDENT RECORD
        {

            Console.WriteLine("\n\n-----DELETE STUDENT RECORD------\n");

            var student = new List<string>() { "Jodie Balaguer", "Michelle Ozoa", "Dale Organo", "Mark Acorda", "Clark Rayos" };

            Console.WriteLine("Student Record contains the following students: ");

            foreach (var names in student)
            {
                Console.WriteLine(names);
            }
            var delname = new List<string>() { "Jodie Balaguer", "Michelle Ozoa", "Dale Organo", "Mark Acorda", "Clark Rayos" };
            delname.Remove("Jodie Balaguer");

            Console.WriteLine("\n***List after removing a student record***");

            foreach (var newlist in delname)
            {
                Console.WriteLine(newlist);     //for example "Jodie Balaguer" is remove from the list.
            }
            Exit();
        }


        public void UpdateRecord() //UPDATE STUDENT RECORD (ADD, REMOVE, INSERT)
        {
            Console.WriteLine("\n\n-----Update Student Profile------\n");

            var entry = new List<string>() { "Juan DelaCruz", "Pedro Penduko", "Super Inggo" };
            entry.Add("Alyssa Briones");
            entry.Insert(3, "Clark Rayos");
            entry.Add("Ronin Lao");
            entry.RemoveRange(0, 2);

            var violators = new List<string>() { "Jodie Balaguer", "Michelle Ozoa", "Dale Organo", "Mark Acorda" };
            violators.AddRange(entry);

            foreach (var entries in violators)
                Console.WriteLine(entries);

            Exit();

        }

        public void Report() //SHOW STUDENT LIST WITH ITS VIOLATION
        {
            string name;
            Console.WriteLine("\n\n-----REPORTS------");
            Console.WriteLine("\n List of Student Violators: \n" +
                "\n1. Jodie Balaguer" + "\n2. Michelle Ozoa" +
               "\n3. Mark Acorda" + "\n4. Clark Rayos\n");

            Console.Write("Enter the number to show student's violation: \n");
            name = Console.ReadLine();

            if (name == "1")
            {
                Console.WriteLine("Violator: Jodie Balaguer " + "\nViolation: Attendance and Punctuality");
            }
            else if (name == "2")
            {
                Console.WriteLine("Violator: Michelle Ozoa" + "\nViolation: Dishonesty");
            }
            else if (name == "3")
            {
                Console.WriteLine("Violator: Mark Acorda " + "\nViolation: Academic Dishonesty");
            }
            else if (name == "4")
            {
                Console.WriteLine("Violator: Clark Rayos " + "\nViolation: Harrassment");
            }
            else
            {
                Console.WriteLine(" Incorrect input name! Enter Again.\n");
                Report();
            }

            Console.Write("\nShow another student violation record? ( y/n )   : ");
            string input = Console.ReadLine();
            if (input.Equals("y"))
            {
                Report();
            }
            else if (input.Equals("n"))
            {
                Exit();
            }
            else
            {
                Console.WriteLine("Invalid. ");
                User.Homepage();
            }

        }

        public void Exit() // TO CLOSE PROGRAM
        {
            Console.Write("\nPress  'y'  if you want to EXIT and  'n'  Back to HOMEPAGE. Thank you.     -");
            char choice = Convert.ToChar(Console.ReadLine());

            if (choice.Equals('y'))
            {
                Console.WriteLine(" Logging out...    Note: You can always back in at any time. Thank you.     ");
                Environment.Exit(0);
            }
            else if (choice.Equals('n'))
            {
                User.Homepage();
            }
            else
            {
                Console.Write(" Invalid. ");
            }
        }

        class Program       //MAIN     //DISPLAY LOGIN FORM
        {
            static void Main(string[] args)
            {
                User user = new User();
                string userAcc = "admin";
                string passAcc = "1234";

                Console.WriteLine("    LOG IN TO CONTINUE.   ");
                Console.WriteLine("**************");
                Console.Write("Enter Username: ");
                userAcc = Console.ReadLine();
                Console.Write("Enter Password: ");
                passAcc = Console.ReadLine();

                if (userAcc == "admin" && passAcc == "1234")
                {
                    Console.WriteLine("\nLogin Successfully.\n");
                    User.Homepage();
                }

                else
                {
                    Console.WriteLine("\nInvalid input. Please Try Again.\n");
                }
            }
        }

    }

}