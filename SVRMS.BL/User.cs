using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// dito po sa class na ito nandito po nakalagay mga options ni user after ng successful login nya sa main program.
// yung method po na homepage para sa mga choice na imamanage ni user like
//view, add, delete, update and if gusto ng user i-close ang program.
//
namespace SVRMS.BL
{
   public class User
    {
        public static void Homepage()     //USER'S MENU AFTER LOGIN
        {
            ManageRecord student = new ManageRecord();

            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("   *** WELCOME TO STUDENT VIOLATION RECORD MANAGEMENT SYSTEM ***   ");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("             1. View Student Record\n" +
                              "             2. Student Entry\n" +
                              "             3. Delete student profile \n" +
                              "             4. Update student record\n" +
                              "             5. Violation Reports\n" +
                              "             6. Exit");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.Write("Choose a number: ");
            var numChoice = Convert.ToInt32(Console.ReadLine());

            if (numChoice == 1)
            {
                StudentRecord.ViewList();
            }
            else if (numChoice == 2)
            {
                ManageRecord.AddStudent();
            }
            else if (numChoice == 3)
            {
                ManageRecord.DeleteRecord();
            }
            else if (numChoice == 4)
            {
                ManageRecord.UpdateRecord();
            }
            else if (numChoice == 5)
            {
                StudentRecord.Report();
            }
            else if (numChoice == 6)
            {
                Exit();
            }
            else
            {
                Console.Write(" Please enter an integer number. Thank you.\n");
                Homepage();
            }
        }

        public static void Exit() // TO CLOSE PROGRAM
        {
            Console.Write("\n Press  'y'  if you want to EXIT. " +
                          "\n Press  'n'  Back to HOMEPAGE. ");
            char choice = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------------------------");

            if (choice.Equals('y'))
            {
                Console.WriteLine("\n\n\n Logging out...    Note: You can always back in at any time. Thank you.     ");
                Environment.Exit(0);
            }
            else if (choice.Equals('n'))
            {
               Homepage();
            }
            else
            {
                Console.Write(" Invalid. ");
            }
        }

    }
}
