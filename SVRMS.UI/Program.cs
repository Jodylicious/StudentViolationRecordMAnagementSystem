using System;
using SVRMS.BL;

//main program po then dito din maglo-login si user for authentication nya sa program.
//if tama ung input ni user, magdidirect po sya sa class ng User, and 
//if mali magcoclose po ang program and irerestart ulit ni user for another login attempt.

namespace SVRMS.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            string userAcc = "admin";
            string passAcc = "1234";
        
           
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("                   LOG IN TO CONTINUE.   ");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.Write("Enter Username: ");
            userAcc = Console.ReadLine();
            Console.Write("Enter Password: ");
            passAcc = Console.ReadLine();
            Console.WriteLine("-------------------------------------------------------------------");

            if (userAcc == "admin" && passAcc == "1234")
            {
                Console.WriteLine("\nLogin Successfully.\n");
                User.Homepage();
            }
            else
            {
                Console.WriteLine("\nInvalid input. Please Restart Again.\n");
            }

        }
    }
}



