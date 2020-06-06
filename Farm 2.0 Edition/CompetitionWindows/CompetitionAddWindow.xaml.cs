using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Farm_2._0_Edition.CompetitionWindows
{
    /// <summary>
    /// Логика взаимодействия для CompetitionAddWindow.xaml
    /// </summary>
    public partial class CompetitionAddWindow : Window
    {
        contextEntities context = new contextEntities();
        public string FilePath;
        
        public CompetitionAddWindow()
        {
            InitializeComponent();
        }

        private void no_but_Click(object sender, RoutedEventArgs e)
        {
            CompetitionMainWindow competitionMainWindow = new CompetitionMainWindow();
            this.Close();
            competitionMainWindow.ShowDialog();
        }

        private void comp_reg_but_Click(object sender, RoutedEventArgs e)
        {
            context.Competition.Add(new Competition
            {
                CompetitionName = comp_name_box.Text,
                CompetitionPrize = comp_prize_box.Text,
                CompetitionType = comp_type_box.Text,
                CompetitionCountry = comp_country_box.Text,
                Photo = File.ReadAllBytes(FilePath)
            });
            context.SaveChanges();
            MessageBox.Show("Соревнование добавлено", "", MessageBoxButton.OK, MessageBoxImage.Information);
            CompetitionMainWindow competitionMainWindow = new CompetitionMainWindow();
            this.Close();
            competitionMainWindow.ShowDialog();
        }

        private void Add_comp_photo_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                FilePath = openFileDialog.FileName;
                this.photo_comp.Source = new BitmapImage(new Uri(FilePath));

            }
        }
    }
}
