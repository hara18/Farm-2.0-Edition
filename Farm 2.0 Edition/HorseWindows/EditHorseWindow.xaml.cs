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
    /// Логика взаимодействия для EditHorseWindow.xaml
    /// </summary>
    public partial class EditHorseWindow : Window
    {
        contextEntities context = new contextEntities();


            
        public EditHorseWindow()
        {
            InitializeComponent();
        }

    

    

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //var horseData = context.Horses.Where(i => i.idHorse == Helper.HelperString).ToList();

            //horse_id_box.Text = horseData.Select(i => i.idHorse).FirstOrDefault();
            //horse_name_box.Text = horseData.Select(i => i.HorseName).FirstOrDefault();
            //horse_breed_box.Text = horseData.Select(i => i.HorseBreed).FirstOrDefault();
            //horse_gender_box.Text = horseData.Select(i => i.HorseGender).FirstOrDefault();
            //horse_age_box.Text = horseData.Select(i => i.HorseAge).FirstOrDefault();
        }

        private void editreg_horse_but_Click(object sender, RoutedEventArgs e)
        {
            //var result = MessageBox.Show("Внести изменения?", "Подтверждение", MessageBoxButton.YesNo, MessageBoxImage.Question);
            //if (result == MessageBoxResult.Yes)
            //{
            //    var horseData = context.Horses.Where(i => i.idHorse == Helper.HelperString).FirstOrDefault();
            //    horseData.idHorse = horse_id_box.Text;
            //    horseData.HorseName = horse_name_box.Text;
            //    horseData.HorseBreed = horse_breed_box.Text;
            //    horseData.HorseAge = horse_age_box.Text;
            //    horseData.HorseGender = horse_gender_box.Text;
                
            //    context.SaveChanges();
            //    MessageBox.Show("Изменения внесены успешно", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

            }
        }

        //private void no_but_Click(object sender, RoutedEventArgs e)
        //{
        //    MainHorseWindow mainHorseWindow = new MainHorseWindow();
        //    this.Close();
        //    mainHorseWindow.ShowDialog();
        }
    

