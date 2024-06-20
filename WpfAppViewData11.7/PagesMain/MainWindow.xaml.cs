using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfAppViewData11._7.PagesMain;

namespace WpfAppViewData11._7.PagesMain
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonConsultant_Click(object sender, RoutedEventArgs e)
        {
            Page1ConsultantEmployee page1ConsultantEmployee = new Page1ConsultantEmployee();
            this.Content = page1ConsultantEmployee;
        }

        private void ButtonManagers_Click(object sender, RoutedEventArgs e)
        {
            Page2ManagersEmployee page2ManagersEmployee = new Page2ManagersEmployee();
            this.Content = page2ManagersEmployee;
        }
    }
}