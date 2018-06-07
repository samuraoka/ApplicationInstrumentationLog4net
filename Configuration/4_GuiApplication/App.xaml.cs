using log4net;
using log4net.Config;
using System.Windows;

// log4net
// https://www.nuget.org/packages/log4net/
// Install-Package -Id log4net -ProjectName 4_GuiApplication
[assembly: XmlConfigurator]

namespace GuiApplication
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static ILog Logger { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            Logger = LogManager.GetLogger(typeof(App));
            Logger.Debug("The logger for this application initialized.");
        }
    }
}
