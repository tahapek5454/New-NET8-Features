

namespace NewVersions
{
    public interface IMailService
    {
        void SendMail()
        {
            Console.WriteLine("Mail Yollandi");
        }

        void ReceiveMail();


        static void StaticMethod()
        {
            Console.WriteLine("Statik");
        }
    }
}