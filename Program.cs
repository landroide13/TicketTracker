using System;
// using System.Collections.Generic;

namespace TicketTracker
{
    class Program
    {

        static void setTicket(string firstName, string surName, string email, string desc)
        {
            Ticket newT = new Ticket(firstName, surName, email, desc);
        }

        static void starter()
        {
            string answer = "";
            while(answer != "no")
            {
                Console.WriteLine("Please Enter your first name");
                string firstName = Console.ReadLine();
                Console.WriteLine("Please Enter your first sure name");
                string surName = Console.ReadLine();    
                Console.WriteLine("Please Enter your email");
                string email = Console.ReadLine();
                Console.WriteLine("Please Describe your problem(This field is compolsory");
                string desc = Console.ReadLine();

                setTicket(firstName, surName, email, desc);

                Console.WriteLine("Do you want to continue ??(yes/no)");
                answer = Console.ReadLine();
                Console.WriteLine("Have a Good day !!");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("######################");
            Console.WriteLine("Welcome Ticket Tracker");
            Console.WriteLine("######################");
            starter();
        }
    }
}
