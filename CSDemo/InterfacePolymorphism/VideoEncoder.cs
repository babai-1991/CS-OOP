using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDemo.InterfacePolymorphism
{
    public class VideoEncoder
    {
        private readonly MailService _mailService;

        public VideoEncoder()
        {
            _mailService = new MailService();
        }
        public void Encode(Video video)
        {
            Console.WriteLine("Video encoded!!");
            _mailService.Send(new Mail());
        }
    }
}
