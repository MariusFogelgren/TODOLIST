using System.Windows.Controls;

namespace WpfApp
{
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        // Handle the Loaded event to reset the TextBox
        private void Page1_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            // Reset the TextBox content when the page is loaded
            MyTaskTextBox.Text = string.Empty;
        }
    }
}
