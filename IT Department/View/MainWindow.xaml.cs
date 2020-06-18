using System.Windows;
using IT_Department;

namespace IT_Department.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            App app = Application.Current as App;
            app.InitializeComponent();
        }
    }
}
