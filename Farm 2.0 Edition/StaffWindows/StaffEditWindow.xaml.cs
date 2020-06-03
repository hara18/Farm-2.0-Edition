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
    /// Логика взаимодействия для StaffEditWindow.xaml
    /// </summary>
    public partial class StaffEditWindow : Window
    {
        contextEntities context = new contextEntities();
        public StaffEditWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var horseData = context.Staff.Where(i => i.StaffLogin == Helper.HelperString).ToList();

            staff_login.Text = horseData.Select(i => i.StaffLogin).FirstOrDefault();
            staff_paswwd.Password = horseData.Select(i => i.StaffPassword).FirstOrDefault();
            staff_name.Text = horseData.Select(i => i.StaffName).FirstOrDefault();
            staff_surname.Text = horseData.Select(i => i.StaffSurname).FirstOrDefault();
            staff_phone.Text = horseData.Select(i => i.Phone).FirstOrDefault();
            staff_gender.Text = horseData.Select(i => i.StaffGender).FirstOrDefault();
            staff_position.Text = horseData.Select(i => i.Position).FirstOrDefault();
        }

        private void editreg_staff_but_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Внести изменения?", "Подтверждение", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                var horseData = context.Staff.Where(i => i.StaffLogin == Helper.HelperString).FirstOrDefault();
                horseData.StaffLogin = staff_login.Text;
                horseData.StaffPassword = staff_paswwd.Password;
                horseData.StaffName = staff_name.Text;
                horseData.StaffSurname = staff_surname.Text;
                horseData.Phone = staff_phone.Text;
                horseData.StaffGender = staff_gender.Text;
                horseData.Position = staff_position.Text;



                context.SaveChanges();
                MessageBox.Show("Изменения внесены успешно", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

            }
        }

        private void no_but_Click(object sender, RoutedEventArgs e)
        {
            StaffMainWindow staffMainWindow = new StaffMainWindow();
            this.Close();
            staffMainWindow.ShowDialog();
        }

        private void deleted_editstaff_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Удалить сотрудника?", "Удаление записи", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                context.Staff.Remove(context.Staff.Where(i => i.StaffLogin == Helper.HelperString).FirstOrDefault());
                context.SaveChanges();
                MessageBox.Show("Сотрудник удалён", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
                MainWindow mainWindow = new MainWindow();
                this.Close();
                mainWindow.ShowDialog();
            }
        }
    }
}

