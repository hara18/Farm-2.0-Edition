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
    /// Логика взаимодействия для StaffMainWindow.xaml
    /// </summary>
    public partial class StaffMainWindow : Window
    {
        contextEntities context = new contextEntities();
        public StaffMainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            staffList.ItemsSource = context.Staff.ToList();
        }

        private void quitapp_but_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void quittomain_but_Click(object sender, RoutedEventArgs e)
        {
            HelloWindow helloWindow = new HelloWindow();
            this.Close();
            helloWindow.ShowDialog();
        }

        private void add_staff_butt_Click(object sender, RoutedEventArgs e)
        {
            AdminStaffRegistrationWindow adminStaffRegistrationWindow = new AdminStaffRegistrationWindow();
            this.Close();
            adminStaffRegistrationWindow.ShowDialog();
        }

        private void edit_staff_butt_Click(object sender, RoutedEventArgs e)
        {
            StaffEditWindow staffEditWindow = new StaffEditWindow();
            this.Close();
            staffEditWindow.ShowDialog();
        }
    }
}
