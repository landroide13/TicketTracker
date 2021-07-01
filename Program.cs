using System;
// using System.Collections.Generic;

namespace TicketTracker
{
    class Program
    {

        public void setTicket(string firstName, string surName, string email, string desc)
        {
            Ticket newT = new Ticket(firstName, surName, email, desc);
        }

        public void starter()
        {
            string answer = "";
            while(answer != "yes")
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
                
            }


        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Ticket Tracker");
            Ticket t1 = new Ticket("Not working");
            // Console.WriteLine(t1.getDescription());
            Ticket t2 = new Ticket("Eltro", "Lazo", "eltro@nz.co", "Monitor not working");
            Console.WriteLine(t2.getStatus());
            Console.WriteLine(t2.getId());
            Console.WriteLine(t2.getName());
            Console.WriteLine(t2.getDescription());
            Console.WriteLine(t2.getStatus());
        }
    }
}
