using log4net;
using System.Threading;
using System.Threading.Tasks;

namespace Common
{
    public class Util
    {
        // log4net
        // https://www.nuget.org/packages/log4net/
        // Install-Package -Id log4net -ProjectName Common
        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger">an instance of log4net logger</param>
        /// <param name="interval">interval in milliseconds</param>
        public static Task[] LoggingDemoWithInterval(ILog logger, int interval)
        {
            Task[] tasks = new Task[5];

            tasks[0] = Task.Run(() => logger.Debug("Debug"));
            Thread.Sleep(interval);

            tasks[1] = Task.Run(() => logger.Info("Info"));
            Thread.Sleep(interval);

            tasks[2] = Task.Run(() => logger.Warn("Warn"));
            Thread.Sleep(interval);

            tasks[3] = Task.Run(() => logger.Error("Error"));
            Thread.Sleep(interval);

            tasks[4] = Task.Run(() => logger.Fatal("Fatal"));

            return tasks;
        }
    }
}
