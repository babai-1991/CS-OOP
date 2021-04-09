using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSDemo.Extensibility
{
    public class DbMigrator
    {
        //this technicque is called dependency injection.
        private readonly ILogger _logger;
        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }


        public void Migrate()
        {
            //details of migrating database..
            _logger.LogInfo($"Migration Started at {DateTime.Now}");
            Thread.Sleep(2000);
            _logger.LogInfo($"Migration Finished at {DateTime.Now}");
        }
    }
}
