namespace WebApplication2.Services
{
    public class YandexMailService : IEmailService
    {
        public void SendMail(string email)
        {
            Console.WriteLine("Yandex");
        }
    }
}
