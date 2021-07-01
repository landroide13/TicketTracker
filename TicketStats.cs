using System;


namespace TicketTracker
{
  class TicketStats
  {
    private int ticketsOpen;
    private int ticketsClosed;
    private int ticketReop;
    static int numberOpen = 0;
    static int numberClosed = 0;
    static int numberReop = 0;
    public TicketStats(){
      numberOpen = 0;
      numberClosed = 0;
      numberReop = 0;
    }

    public int getTicketClosed(){
      return ticketsClosed;
    }

    public int getTicketOpen(){
      return ticketsOpen;
    }

    public int getTicketReopen(){
      return ticketReop;
    }

    



  }


























}



































