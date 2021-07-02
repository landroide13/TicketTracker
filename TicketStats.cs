using System;
using System.Collections.Generic;

namespace TicketTracker
{
  class TicketStats
  {
    // private List<Ticket> ticketList;
    private int ticketsOpen;
    private int ticketsClosed;
    private int ticketReop;
    static int numberOpen = 0;
    static int numberClosed = 0;
    static int numberReop = 0;

    public TicketStats(){}

    public int getTicketClosed(List<Ticket> list)
    {
      int ticketsClose = 0;
      
      foreach(Ticket tk in list)
      {
        if(tk.getStatus() == "Closed")
        {
          ticketsClose++;
        }
      }
      return ticketsClose;
    }

    public int getTicketOpen(List<Ticket> list)
    {
      int ticketsOpen = 0;
      foreach(Ticket tk in list)
      {
        if(tk.getStatus() == "Open")
        {
          ticketsOpen++;
        }
      }
      return ticketsOpen;
    }

    public int getTicketReopen(List<Ticket> list)
    {
      int ticketsReopen = 0;
      foreach(Ticket tk in list)
      {
        if(tk.getStatus() == "Reopen")
        {
          ticketsReopen++;
        }
      }
      return ticketsReopen;
    }

    



  }


























}



































