using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//dito po sa class na ito nakalagay ung viewlist method para ipakita sa user ung mga nakastore na data
// for examples lang po ung mga test data na ginamitan ko po ng list.
//ung report method naman po is para ipakita kay user ung list ng student na may mga violation record din
//for examples din po ang mga test data na ginamitan ko po ng list.

namespace SVRMS.BL
{
    class StudentRecord
    {
        public static void ViewList()
        {
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("                       STUDENT RECORD LIST                         ");
            Console.WriteLine("-------------------------------------------------------------------");

            List<string> studentlist = new List<string>() { "Jodie Balaguer", "Michelle Ozoa", "McDale Organo", "Mark Acorda", "Clark Rayos" };

            foreach (var names in studentlist)
            {
                Console.WriteLine(names);
            }
            User.Exit();
        }

        public static void Report() //SHOW STUDENT LIST WITH ITS VIOLATION
        {
            string name;
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("                             REPORTS                               ");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("\n List of Student Violators: \n" +
                "\n1. Jodie Balaguer" + "\n2. Michelle Ozoa" +
               "\n3. Mark Acorda" + "\n4. Clark Rayos\n");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("Enter the number to show student's violation: \n");
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
                User.Exit();
            }
            else
            {
                Console.WriteLine("Invalid. ");
                User.Homepage();
            }

        }

    }
}
