using Common;
using log4net;
using log4net.Appender;
using log4net.Config;
using log4net.Core;
using log4net.Layout;
using log4net.Repository.Hierarchy;
using System.Reflection;
using System.Threading.Tasks;

namespace ConfigureInCode
{
    class Program
    {
        private static void ConfigureLog4netInCode()
        {
            // log4net
            // https://www.nuget.org/packages/log4net/
            // Install-Package -Id log4net -ProjectName 5_ConfigureInCode
            var layout = new SimpleLayout();
            layout.ActivateOptions();

            var appender = new ConsoleAppender();
            appender.Layout = layout;
            appender.ActivateOptions();

            var hierarchy = (Hierarchy)LogManager.GetRepository(Assembly.GetEntryAssembly());
            Logger root = hierarchy.Root;
            root.Level = Level.All;

            BasicConfigurator.Configure(hierarchy, appender);
        }

        private static int _interval = 0;

        private static void ParseArguments(string[] args)
        {
            if (args.Length != 0)
            {
                int.TryParse(args[0], out _interval);
            }
        }

        static void Main(string[] args)
        {
            ConfigureLog4netInCode();

            // output log
            ParseArguments(args);
            var logger = LogManager.GetLogger(typeof(Program));
            var tasks = Util.LoggingDemoWithInterval(logger, _interval);
            Task.WaitAll(tasks);
        }
    }
}
