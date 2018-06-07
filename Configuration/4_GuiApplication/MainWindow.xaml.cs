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

            App.Logger.Debug("MainWindow has initialized.");
        }
    }
}
