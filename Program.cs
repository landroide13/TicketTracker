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

        static void displayStats(List<Ticket> li)
        {
            TicketStats open = new TicketStats();
            TicketStats close = new TicketStats();
            TicketStats reopen = new TicketStats();

            Console.WriteLine("#############################################################################################################");
            Console.WriteLine("Tickets Open: " + open.getTicketOpen(li));
            Console.WriteLine("Tickets Close: " + close.getTicketClosed(li));
            Console.WriteLine("Tickets Reopen: " + reopen.getTicketReopen(li));
            Console.WriteLine("##############################################################################################################");
        }

        static void options(List<Ticket> li)
        {
          Console.WriteLine("###############################################################################################################");
          Console.WriteLine("Would you like display all the tickest(option A) ,  Check the stats(option B), Generated a new Ticket(option C");
          Console.WriteLine("###############################################################################################################");
          string choice = Console.ReadLine();
          Console.WriteLine("###############################################################################################################");
          if(choice == "A")
          {
            getList(li);    
          }
          else if(choice == "B")
          {
            displayStats(li); 
          }else
          {
            getList(li); 
          }
        }

        static void getList(List<Ticket> tiL) //Iterate the List.
        {
          foreach(Ticket tk in tiL)
            {
                int number = tk.getNumberTic();
                string stuffId = tk.getId();
                string name = tk.getName();
                string email = tk.getEmail();
                string description = tk.getDescription();
                string status = tk.getStatus();
                string response = tk.getResponse();
                Console.WriteLine("############################################################");
                Console.WriteLine("The ticket Number: " + number);
                Console.WriteLine("The Creator is: " + name);
                Console.WriteLine("The StuffId: " + stuffId);
                Console.WriteLine("The Email is: " + email);
                Console.WriteLine("The description of the problem is: " + description);
                Console.WriteLine("The Response: " + response);
                Console.WriteLine("The Ticket status is: " + status);
                Console.WriteLine("#############################################################");
            }
        }
        static void starter()
        {
            string answer = "";
            List<Ticket> tikList = new List<Ticket>();// Creates a new List
            while(answer != "no")
            {
                Console.WriteLine("########### Lets Generate a Tickets #######################");
                Console.WriteLine("############################################################");
                Console.WriteLine("Are you able to share your personal details(yes/no) ??");
                string details = Console.ReadLine();
                Console.WriteLine("##############################################################");
                Ticket newTicket;
                if(details == "yes")
                {
                    Console.WriteLine("Please Enter your first name");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Please Enter your surename");
                    string surName = Console.ReadLine();    
                    Console.WriteLine("Please Enter your email");
                    string email = Console.ReadLine();
                    Console.WriteLine("Please Describe your problem(This field is compolsory)");
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
                Console.WriteLine("Ticket Created !! ");

                // Options Functions
                options(tikList);

                //Good Bye
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














