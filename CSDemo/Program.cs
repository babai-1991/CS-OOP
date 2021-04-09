using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSDemo.Extensibility;
using CSDemo.InterfacePolymorphism;
using CSDemo.InterfaceTestibility;


namespace CSDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //DbMigrator migrator = new DbMigrator(new Logger());
            //Installer installer = new Installer(new Logger());

            //migrator.Notify();
            //installer.Notify();

            //var orderProcessor = new OrderProcessor(new ShippingCalculator());
            //var order = new Order() {DatePlaced = DateTime.Now, TotalPrice = 100f};
            //orderProcessor.Process(order);


            //var dbMigrator = new DbMigrator(new ConsoleLogger());
            //dbMigrator.Migrate();

            //var dbMigrator2 = new DbMigrator(new FileLogger("C:\\LogMessage\\FileLogger.txt"));
            //dbMigrator2.Migrate();

            var videoEncoder = new VideoEncoder();
            videoEncoder.RegisterNotificationChannel(new MailNotificationChannel());
            videoEncoder.RegisterNotificationChannel(new SmsNotificationChannel());
            
            
            videoEncoder.Encode(new Video());
        }
    }
}
