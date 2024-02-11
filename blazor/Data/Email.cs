using System.ComponentModel.DataAnnotations;

namespace blazor.Data;

public class Email
{
   
    public string Sender { get; set; }
    
    [Required (ErrorMessage = "who recieving????")]
    public string Reciever { get; set; }
    
    [Required (ErrorMessage = "whats the title ????")]
    public string Title { get; set; }
    
    [Required (ErrorMessage = "whats the body ????")]
    public string Body { get; set; }
    public DateTime TimeSent { get; set; }  
    
    public Email(string sender, string reciever, string title, string body, DateTime timeSent)
    {
        Sender = sender;
        Reciever = reciever;
        Title = title;
        Body = body;
        TimeSent = timeSent;
    }
    
}