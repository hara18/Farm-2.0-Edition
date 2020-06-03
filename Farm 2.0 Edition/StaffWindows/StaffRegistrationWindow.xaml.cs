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
using System.Windows.Shapes;

namespace Farm_2._0_Edition.StaffWindows
{
    /// <summary>
    /// Логика взаимодействия для StaffRegistrationWindow.xaml
    /// </summary>
    public partial class StaffRegistrationWindow : Window
    {
        contextEntities context = new contextEntities();
        public StaffRegistrationWindow()
        {
            InitializeComponent();
        }

        private void reg_staff_but_Click(object sender, RoutedEventArgs e)
        {
            context.Staff.Add(new Staff
            {
                StaffName = staff_name.Text,
                StaffSurname = staff_surname.Text,
                StaffGender = staff_gender.Text,
                Phone = staff_phone.Text,
                StaffLogin = staff_login.Text,
                StaffPassword = staff_paswwd.Password
            });
            context.SaveChanges();
            MessageBox.Show("Регистрация прошла успешно", "", MessageBoxButton.OK,MessageBoxImage.Information);
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.ShowDialog();
        }

        private void no_but_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.ShowDialog();
        }
    }
}
