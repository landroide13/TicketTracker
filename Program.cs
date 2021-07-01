using System;
using System.Collections.Generic;

namespace TicketTracker
{
    class Program
    {
        static void closing(string answer)
        {
            if(answer != "yes")
                {
                  Console.WriteLine("Have a Good day !!");
                }
                else
                {
                  Console.WriteLine("Lets Continue..");  
                }
        }
        static void starter()
        {
            string answer = "";
            List<Ticket> tikList = new List<Ticket>();
            while(answer != "no")
            {
                Console.WriteLine("Are you able to share your personal details(yes/no) ??");
                string details = Console.ReadLine();
                Ticket newTicket;
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

                    newTicket = new Ticket(firstName, surName, email, desc);
                }
                else
                {
                    Console.WriteLine("Please Describe your problem(This field is compolsory)");
                    string desc = Console.ReadLine();

                    newTicket = new Ticket(desc);
                }

                tikList.Add(newTicket);
                Console.WriteLine("Tickets Created: " + tikList.Count);
                foreach(Ticket tk in tikList)
                {
                    string description = tk.getDescription();
                    Console.WriteLine("The description of the problem is: " + description);
                }



                Console.WriteLine("Do you want to continue ??(yes/no)");
                answer = Console.ReadLine();
                closing(answer);

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














