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

namespace Farm_2._0_Edition.HorseWindows
{
    /// <summary>
    /// Логика взаимодействия для AddHorseWindow.xaml
    /// </summary>
    public partial class AddHorseWindow : Window
    {
        contextEntities context = new contextEntities();
        public AddHorseWindow()
        {
            InitializeComponent();
        }

        
        private void reg_horse_but_Click(object sender, RoutedEventArgs e)
        {
            context.Horses.Add(new Horses
            {
                HorseName = horse_name_box.Text,
                HorseAge = horse_age_box.Text,
                HorseBreed = horse_breed_box.Text,
                HorseGender = horse_gender_box.Text,
                
            });
            context.SaveChanges();
            MessageBox.Show("Лошадь добавлена в систему", "", MessageBoxButton.OK,MessageBoxImage.Information);
        }

        private void no_but_Click(object sender, RoutedEventArgs e)
        {
            MainHorseWindow mainHorseWindow = new MainHorseWindow();
            this.Close();
            mainHorseWindow.ShowDialog();
        }
    }
}
