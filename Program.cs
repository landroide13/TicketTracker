using System;

namespace TicketTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Ticket Tracker");
            Ticket t1 = new Ticket("Not working");
            // Console.WriteLine(t1.getDescription());
            Ticket t2 = new Ticket("Eltro", "Lazo", "eltro@nz.co", "Password Change");
            Console.WriteLine(t2.getStatus());
            Console.WriteLine(t2.getId());
            Console.WriteLine(t2.getName());
            Console.WriteLine(t2.getDescription());
        }
    }
}
