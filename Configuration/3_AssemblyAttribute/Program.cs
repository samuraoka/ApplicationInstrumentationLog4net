using log4net;
using log4net.Config;
using System.Threading;
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

            // output loggin
            Task.Run(() => logger.Debug("Debug"));
            Thread.Sleep(1000);

            Task.Run(() => logger.Info("Info"));
            Thread.Sleep(1000);

            Task.Run(() => logger.Warn("Warn"));
            Thread.Sleep(1000);

            Task.Run(() => logger.Error("Error"));
            Thread.Sleep(1000);

            Task.Run(() => logger.Fatal("Fatal"));
            Thread.Sleep(1000);
        }
    }
}
