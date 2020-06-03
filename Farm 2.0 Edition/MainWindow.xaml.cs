using Farm_2._0_Edition.StaffWindows;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Farm_2._0_Edition
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        contextEntities context = new contextEntities();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void quit_but_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void login_but_Click(object sender, RoutedEventArgs e)
        {
            var qwery = context.Staff.Where(i => i.StaffLogin == auth_login.Text && i.StaffPassword == auth_passwd.Password).ToList();

            if (qwery.Count > 0)
            {

                Helper.HelperString = auth_login.Text;
                HelloWindow helloWindow = new HelloWindow();
                this.Hide();
                helloWindow.ShowDialog();
               

            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }

        private void reg_but_Click(object sender, RoutedEventArgs e)
        {
            StaffRegistrationWindow staffRegistrationWindow = new StaffRegistrationWindow();
            this.Close();
            staffRegistrationWindow.ShowDialog();
        }
       

    }
}
