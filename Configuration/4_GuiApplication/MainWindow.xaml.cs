using Common;
using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows;

namespace GuiApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Closing += OnClosingLogging;
            Closed += OnClosedLogging;
            btnLogging.Click += DemoLogging;

            App.Logger.Debug("MainWindow has initialized.");
        }

        private void OnClosedLogging(object sender, EventArgs e)
        {
            Logging("Closed");
        }

        private void OnClosingLogging(object sender, CancelEventArgs e)
        {
            Logging("Closing");
        }

        private void Logging(string message)
        {
            App.Logger.Debug("MainWindow: " + message);
        }

        private void DemoLogging(object sender, RoutedEventArgs e)
        {
            Task.Run(() =>
            {
                Task[] tasks = Util.LoggingDemoWithInterval(App.Logger, 500);
                Task.WaitAll(tasks);
            });
        }
    }
}
