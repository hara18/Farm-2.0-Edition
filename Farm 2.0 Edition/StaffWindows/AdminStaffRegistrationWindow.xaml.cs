using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для AdminStaffRegistrationWindow.xaml
    /// </summary>
    public partial class AdminStaffRegistrationWindow : Window
    {
        contextEntities context = new contextEntities();
        public string FilePath;
        public AdminStaffRegistrationWindow()
        {
            InitializeComponent();
        }
        private void reg_staff_but_Click(object sender, RoutedEventArgs e)
        {
            context.Staff.Add(new Staff
            {
                StaffName = staff_name.Text,
                StaffSurname = staff_surname.Text,
                Position = staff_position.Text,
                StaffGender = staff_gender.Text,
                Phone = staff_phone.Text,
                StaffLogin = staff_login.Text,
                StaffPassword = staff_paswwd.Password,
                Photo = File.ReadAllBytes(FilePath)
            });
            context.SaveChanges();
            MessageBox.Show("Регистрация прошла успешно", "", MessageBoxButton.OK, MessageBoxImage.Information);
            StaffMainWindow staffMainWindow = new StaffMainWindow();
            this.Close();
            staffMainWindow.ShowDialog();
        }

        //private void enroll(object sender, RoutedEventArgs e)
        //{
        //    context.Staff.Find(new Staff
        //    {
        //        StaffName = staff_name.Text,
        //        StaffSurname = staff_surname.Text,
        //        StaffGender = staff_gender.Text,
        //        StaffPassword = staff_paswwd.Password,

        //    });
        //}

        private void no_but_Click(object sender, RoutedEventArgs e)
        {
            StaffMainWindow staffMainWindow = new StaffMainWindow();
            this.Close();
            staffMainWindow.ShowDialog();
        }

        private void Add_staff_photo_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                FilePath = openFileDialog.FileName;
                this.photo_staff.Source = new BitmapImage(new Uri(FilePath));

            }
        }
    }
}