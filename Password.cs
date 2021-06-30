using System;

namespace TicketTracker
{

  class Password
  {
    private string staffId;

    private int ticketNumber;

    private string timestamp;

    public Password()
    {
      this.staffId = "";
      this.ticketNumber = 0;
      this.timestamp = "";
    }

    public Password(string staffId, int ticketNumber)
    {
      this.staffId = staffId;
      this.ticketNumber = ticketNumber;
      this.timestamp = DateTime.Now.ToString();
    }

    public string genNewPassword()
    {
      string pass1 = staffId.Substring(0,2);
      string pass2 = ticketNumber.ToString("X");

      string timeSt = timestamp.Substring(0, 2) + timestamp[3];
      int numberT = Convert.ToInt32(timeSt);
      string pass3Hex = numberT.ToString("X");

      string newPass = pass1 + pass2 + pass3Hex;

      return newPass;

    }

  }


}