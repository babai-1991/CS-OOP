using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDemo.InterfacePolymorphism
{
    public class VideoEncoder
    {
        //private readonly MailService _mailService;

        private IList<INotificationChannel> _notification;

        public VideoEncoder()
        {
            _notification = new List<INotificationChannel>();
        }
        public void Encode(Video video)
        {
            Console.WriteLine("Video encoded!!");
            foreach (var notification in _notification)
            {
                notification.Send(new Message());
            }
        }

        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notification.Add(channel);
        }
    }
}
