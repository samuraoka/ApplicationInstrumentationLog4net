using log4net;
using log4net.Config;
using System.Reflection;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // log4net
            // https://www.nuget.org/packages/log4net/
            // Install-Package -Id log4net -ProjectName Demo
            //
            // https://stackify.com/making-log4net-net-core-work/
            // http://crbtech.in/Dot-Net-Training/ways-to-configure-log4net-for-dotnet-core/
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            BasicConfigurator.Configure(logRepository);
            var log = LogManager.GetLogger(typeof(Program));
            log.Info("Hello from log4net!");
        }
    }
}
