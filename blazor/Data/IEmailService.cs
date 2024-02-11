namespace blazor.Data;

public interface IEmailService
{
    public Task SendEmail(Email email);
    public List<Email> ViewEmail();
    public EmailStatistics GetEmailStatistics();
}