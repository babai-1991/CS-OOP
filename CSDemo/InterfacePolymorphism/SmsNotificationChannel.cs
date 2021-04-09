using System;

namespace CSDemo.InterfacePolymorphism
{
    public class SmsNotificationChannel:INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending messages after encoding.....");
        }
    }
}