namespace DependencyInversion
{
    public class Report
    {

        private ISender sender;

        public Report(ISender sender)
        {
            this.sender = sender;
        }
        public void Send(string to)
        {
            //MailSender mailSender = new MailSender();   
            sender.Send(to);
        }
    }

    public interface ISender
    {
        void Send(string to);
    }
    public class MailSender : ISender
    {
        public void Send(string to) => Console.WriteLine("Mail gönderildi");
    }

    public class WhatsAppSender : ISender
    {
        public void Send(string to)
        {
            Console.WriteLine("WA mesajı gönderildi");
        }
    }

    public class Telegram : ISender
    {
        public void Send(string to)
        {
            Console.WriteLine("Telegram mesajı gönderildi");
        }
    }
}
