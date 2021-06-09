using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//dito po sa class ng ManageRecord nakainclude ung add, delete, update na gagawin ni user.
//for examples din po ung mga nakalagay na test data na ginamitan ko po ng list.

namespace SVRMS.BL
{
   public class ManageRecord
    {
            public static void AddStudent()     // TO ADD STUDENT AND ITS VIOLATION
            {
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("                             STUDENT ENTRY                         ");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.Write("Enter Student Number: ");
            var id = Console.ReadLine();
            Console.Write("Student First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Student Last Name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("\n *** STUDENT ENTRY ***");
            Console.WriteLine("Student Number: {0}  \nStudent Name: {1} {2} \n", id, firstName, lastName);
            Console.WriteLine("-------------------------------------------------------------------");

            Console.WriteLine("\nLIST OF VIOLATION: " +
                                 "\na. ACADEMIC DISHONESTY ( Cheating, Plagiarism )" +
                                 "\nb. ATTENDANCE AND PUNCTUALITY ( Late, Absence, Tardy )" +
                                 "\nc. HARRASSMENT ( Bullying, Sexual Harrassment, Fighting)" +
                                 "\nd. DAMAGE TO PROPERTY ( Vandalism )\n");
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
                       AddStudent();
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
                User.Exit();
            }




            public static void DeleteRecord()      //DELETE STUDENT RECORD
            {

            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("                             DELETE RECORD                         ");
            Console.WriteLine("-------------------------------------------------------------------");

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
                User.Exit();
            }




            public static void UpdateRecord() //UPDATE STUDENT RECORD (ADD, REMOVE, INSERT)
            {
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("                        UPDATE STUDENT ENTRY                       ");
            Console.WriteLine("-------------------------------------------------------------------");

            var entry = new List<string>() { "Juan DelaCruz", "Pedro Penduko", "Super Inggo" };
                entry.Add("Alyssa Briones");
                entry.Insert(3, "Clark Rayos");
                entry.Add("Ronin Lao");
                entry.RemoveRange(0, 2);

                var violators = new List<string>() { "Jodie Balaguer", "Michelle Ozoa", "Dale Organo", "Mark Acorda" };
                violators.AddRange(entry);

                foreach (var entries in violators)
                    Console.WriteLine(entries);

                User.Exit();
            }
   }
}
