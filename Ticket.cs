using System;

namespace TicketTracker
{
  class Ticket
  {
    static int ticNum = 2000;
    private int ticId;
    private string stuffId;
    private string status;
    private string firstName;
    private string surName;
    private string email;
    private string description;
    public string setStuffId(string firstName, string surname)
    {
      return firstName + surname[0];
    }

    public Ticket(string firstName, string surName, string statusTic, string emailTic, string descriptionTic)
    {
      ticId++;
      this.ticId = ticNum;
      this.firstName = firstName;
      this.surName = surName;
      this.stuffId = setStuffId(firstName, surName);
      this.status = statusTic;
      this.description = descriptionTic;
      this.email = emailTic;
    }

    public Ticket(string descriptionTic)
    {
      this.stuffId = "No Specified";
      this.description = descriptionTic;
      this.email = "No Specified";
      this.firstName = "No Specified";
    }

    public string getId()
    {
      return stuffId;
    }

    public int getNumberTic()
    {
      return ticId;
    }

    public string getName()
    {
      return firstName;
    }

    public string getStatus()
    {
      return status;
    }

    public string getDescription()
    {
      return description;
    }

    public string getEmail()
    {
      return email;
    }

    public void setName(string newFirst, string newLast)
    {
      firstName = newFirst;
      surName = newLast;
    }

    public void setStatus(string newStatus)
    {
      status = newStatus;
    }

    public void setEmail(string newEmail)
    {
      email = newEmail;
    }

    public void setDescription(string newDescription)
    {
      description = newDescription;
    }

    public string getStuffId(){
      return stuffId;
    }




  }


}

