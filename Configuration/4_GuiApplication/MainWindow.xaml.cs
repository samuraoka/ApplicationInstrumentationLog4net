using System;
using System.ComponentModel;
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
    }
}
