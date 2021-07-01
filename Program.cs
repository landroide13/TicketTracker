using System;
// using System.Collections.Generic;

namespace TicketTracker
{
    class Program
    {

        static object setTicket1(string firstName, string surName, string email, string desc)
        {
          Ticket newT = new Ticket(firstName, surName, email, desc);
          return newT;
        }
        
        static object setTicket2(string desc)
        {
          Ticket newT = new Ticket(desc);
          return newT;
        }

        static void starter()
        {
            string answer = "";
            while(answer != "no")
            {
                Console.WriteLine("Are you able to share your personal details(yes/no) ??");
                string details = Console.ReadLine();
                if(details == "yes")
                {
                    Console.WriteLine("Please Enter your first name");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Please Enter your first sure name");
                    string surName = Console.ReadLine();    
                    Console.WriteLine("Please Enter your email");
                    string email = Console.ReadLine();
                    Console.WriteLine("Please Describe your problem(This field is compolsory");
                    string desc = Console.ReadLine();

                    object newTicket = setTicket1(firstName, surName, email, desc);
                }
                else
                {
                    Console.WriteLine("Please Describe your problem(This field is compolsory");
                    string desc = Console.ReadLine();

                    object newTicket = setTicket2(desc);
                }


                

                

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
