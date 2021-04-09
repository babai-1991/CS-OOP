using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSDemo.Composition;

namespace CSDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DbMigrator migrator = new DbMigrator(new Logger());
            Installer installer = new Installer(new Logger());

            migrator.Notify();
            installer.Notify();
        }
    }
}
