using Common;
using log4net;
using log4net.Config;
using System.Reflection;
using System.Threading.Tasks;

namespace Configuration
{
    class Program
    {
        static void Main(string[] args)
        {
            // log4net
            // https://www.nuget.org/packages/log4net/
            // Install-Package -Id log4net -ProjectName 1_Configuration
            var repo = LogManager.GetRepository(Assembly.GetEntryAssembly());
            BasicConfigurator.Configure(repo);
            var logger = LogManager.GetLogger(typeof(Program));

            logger.Info(" First Column: Ellapsed millisecond from the beginning of the program.");
            logger.Info("Second Column: Thread Id");
            logger.Info(" Third Column: The severity of the Logging Event");
            logger.Info(" Forth Column: The place Logging Event happend");
            logger.Info(" Fifth Column: The message of the Logging Event");

            Task[] tasks = Util.LoggingDemoWithInterval(logger, 500);
            Task.WaitAll(tasks);
        }
    }
}
