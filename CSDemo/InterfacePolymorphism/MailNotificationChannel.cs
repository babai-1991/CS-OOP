using System;

namespace CSDemo.InterfacePolymorphism
{
    public class MailNotificationChannel:INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending mail after encoding.....");
        }
    }
}