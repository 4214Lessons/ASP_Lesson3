namespace WebApplication2.Services
{
    public class GmailService : IEmailService
    {
        public GmailService()
        {
            Console.WriteLine("Email Ctor");
        }
        public void SendMail(string email)
        {
            Console.WriteLine("Mail has been sent");
        }
    }
}
