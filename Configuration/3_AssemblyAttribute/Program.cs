using Common;
using log4net;
using log4net.Config;
using System.Threading.Tasks;

// For this setting, XmlConfigurator read configuration from App.config file. 
[assembly: XmlConfigurator]

namespace AssemblyAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            // log4net
            // https://www.nuget.org/packages/log4net/
            // Install-Package -Id log4net -ProjectName 3_AssemblyAttribute
            var logger = LogManager.GetLogger(typeof(Program));

            // output logging
            Task[] tasks = Util.LoggingDemoWithInterval(logger, 500);
            Task.WaitAll(tasks);
        }
    }
}
