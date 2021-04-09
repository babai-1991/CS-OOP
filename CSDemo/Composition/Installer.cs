using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDemo.Composition
{
    public class Installer
    {
        private Logger _logger;

        public Installer(Logger logger)
        {
            _logger = logger;
        }

        public void Notify()
        {
            _logger.Log("Installed..");
        }

    }
}
