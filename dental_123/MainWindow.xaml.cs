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

namespace dental_123
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


        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username;
            string password;

            // Validate the credentials (replace with your actual validation logic)
            if (Username == "Admin" && password == "1223")
            {
                // Redirect to receptionist page
                ReceptionistPage receptionistPage = new ReceptionistPage();
                receptionistPage.Show();
                this.Close();
            }
            else if (username == "AdminD" && password == "1224")
            {
                // Redirect to doctor page
                DoctorPage doctorPage = new DoctorPage();
                doctorPage.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }
    }
}