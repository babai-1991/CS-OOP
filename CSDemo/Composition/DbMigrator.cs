using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDemo.Composition
{
    public class DbMigrator
    {
        private Logger _logger;

        public DbMigrator(Logger logger)
        {
            _logger = logger;
        }

        public void Notify()
        {
            _logger.Log("Message from DBMigrator");
        }
    }
}
