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
   

    public Ticket(string firstName, string surName, string emailTic, string descriptionTic)
    {
      ticId++;
      this.ticId = ticNum;
      this.firstName = firstName;
      this.surName = surName;
      this.stuffId = firstName + surName[0];
      this.description = descriptionTic;
      this.email = emailTic;
      this.status = "Open";

     checkDescription(descriptionTic);

    }

    public Ticket(string descriptionTic)
    {
      this.stuffId = "No Specified";
      this.description = descriptionTic;
      this.email = "No Specified";
      this.firstName = "No Specified";
      this.status = "Open";

      checkDescription(descriptionTic);

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

    public void checkDescription(string description)
    {
      if(description.Contains("Password Change"))
      {
        status = "Closed";
        Password newPasword = new Password(getId(), getNumberTic());
        newPasword.genNewPassword();
      }
    }




  }


}

