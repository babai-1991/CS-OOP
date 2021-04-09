using System;

namespace CSDemo.InterfacePolymorphism
{
    public class MailService
    {
        public void Send(Mail mail)
        {
            Console.WriteLine("Sending email....");
        }
    }
}