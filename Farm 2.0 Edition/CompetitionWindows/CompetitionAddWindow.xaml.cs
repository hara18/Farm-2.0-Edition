using System.Windows;

namespace Farm_2._0_Edition.CompetitionWindows
{
    /// <summary>
    /// Логика взаимодействия для CompetitionAddWindow.xaml
    /// </summary>
    public partial class CompetitionAddWindow : Window
    {
        contextEntities context = new contextEntities();
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
                CompetitionCountry = comp_country_box.Text
            });
            context.SaveChanges();
            MessageBox.Show("Соревнование добавлено", "", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
