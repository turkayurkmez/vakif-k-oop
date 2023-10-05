namespace Decorator
{

    public interface IMail
    {
        void Send();
    }
    public class MailMessage : IMail
    {
        public void Send() => Console.WriteLine("E-posta gönderildi!");

    }

    public abstract class MailDecorator : IMail
    {
        protected IMail _mail;

        protected MailDecorator(IMail mail)
        {
            _mail = mail;
        }

        public abstract void Send();
    }

    public class SignedMail : MailDecorator
    {

        public SignedMail(IMail mail) : base(mail)
        {

        }

        public string SignedBy { get; set; }
        public override void Send()
        {
            Console.WriteLine($"{SignedBy} tarafından imzalandı");
            this._mail.Send();
        }


    }

    public class CryptoMail : MailDecorator
    {


        public CryptoMail(IMail mail) : base(mail)
        {

        }

        public override void Send()
        {
            Console.WriteLine("Eposta şifrelendi");
            this._mail.Send();
        }
    }
}
