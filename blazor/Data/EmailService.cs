namespace blazor.Data;

public class EmailService:IEmailService
{
   public List<Email> Emails { set; get; }

   public EmailService()
   {
       // Initialize the list of emails
       Emails = new List<Email>();
       DateTime currentTime = DateTime.Now;
       
       Emails.Add(new Email("me@example.com", "reciever1@example.com", "bigboy", "hello", currentTime));
       Emails.Add(new Email("me@example.com", "reciver2@example.com", "smallboy", "nice", currentTime));

       // Some where someone else is the sender
       Emails.Add(new Email("Sender1@example.com", "me@example.com", "title1", "Bodyman", currentTime));
       Emails.Add(new Email("Sender2@example.com", "me@example.com", "title1", "hellowwassup", currentTime));
       Emails.Add(new Email("Sender3@example.com", "me@example.com", "title1", "nah", currentTime));
       
       
   }
   public async Task SendEmail(Email email)
   {
       // Set the TimeSent to the current time
       email.TimeSent = DateTime.Now;

       // Set the Sender to a hardcoded string
       email.Sender = "kris"; 

       // Add the Email to the list of emails
       Emails.Add(email);
  
   }

   public List<Email> ViewEmail()
   {
       return Emails;
   }
   
   public EmailStatistics GetEmailStatistics()
   {
       // Implement logic to calculate email statistics
       int sentByYouCount = Emails.Count(e => e.Sender == "Your Name");
       int receivedByOthersCount = Emails.Count(e => e.Reciever != "Recievrs");

       return new EmailStatistics
       {
           SentByYouCount = sentByYouCount,
           ReceivedByOthersCount = receivedByOthersCount
       };
   }
}
   
