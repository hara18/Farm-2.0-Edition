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

namespace Farm_2._0_Edition.HorseWindows
{
    /// <summary>
    /// Логика взаимодействия для AddHorseWindow.xaml
    /// </summary>
    public partial class AddHorseWindow : Window
    {
        contextEntities context = new contextEntities();
        public string FilePath;
        public int hehe;
        public AddHorseWindow()
        {
            InitializeComponent();
        }


        private void Add_horse_photo_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                FilePath = openFileDialog.FileName;
                this.photo_horse.Source = new BitmapImage(new Uri(FilePath));

            }
        }


        private void reg_horse_but_Click(object sender, RoutedEventArgs e)
        {
            context.Horses.Add(new Horses
            {
                idHorse = hehe,
                HorseName = horse_name_box.Text,
                HorseAge = horse_age_box.Text,
                HorseBreed = horse_breed_box.Text,
                HorseGender = horse_gender_box.Text,
                Photo = File.ReadAllBytes(FilePath)

            }); ;
            context.SaveChanges();
            MessageBox.Show("Лошадь добавлена в систему", "", MessageBoxButton.OK, MessageBoxImage.Information);
            MainHorseWindow mainHorseWindow = new MainHorseWindow();
            this.Close();
            mainHorseWindow.ShowDialog();
        }

        private void no_but_Click(object sender, RoutedEventArgs e)
        {
            MainHorseWindow mainHorseWindow = new MainHorseWindow();
            this.Close();
            mainHorseWindow.ShowDialog();
        }

        private void horse_id_box_KeyUp(object sender, KeyEventArgs e)
        {
            if (horse_id_box.Text == "")
            {
                hehe = 0;
            }
            else
            {
                hehe = Convert.ToInt32(horse_id_box.Text);
            }
        }
    }
}
