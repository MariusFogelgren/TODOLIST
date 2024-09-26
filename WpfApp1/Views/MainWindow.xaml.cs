using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly NavigationService _navigationService;
        public static NavigationService NavigationService => ((MainWindow)Application.Current.MainWindow).frmMain.NavigationService;


        //public MainWindow(NavigationService navigationService)
        public MainWindow()
        {
            InitializeComponent();
            _navigationService = NavigationService.GetNavigationService(this);
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

            _navigationService.Navigate(new Uri("Page1.xaml", UriKind.Relative));

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }



    }
}