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

namespace Farm_2._0_Edition.CompetitionWindows
{
    /// <summary>
    /// Логика взаимодействия для CompetitionMainWindow.xaml
    /// </summary>
    public partial class CompetitionMainWindow : Window
    {
        contextEntities context = new contextEntities();
        public CompetitionMainWindow()
        {
            InitializeComponent();
        }

        private void quittomain_but_Click(object sender, RoutedEventArgs e)
        {
            HelloWindow helloWindow = new HelloWindow();
            this.Close();
            helloWindow.ShowDialog();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {


            competitionList.ItemsSource = context.Competition.ToList();

        }

        private void quitapp_but_Click(object sender, RoutedEventArgs e)
        {
            {
                Application.Current.Shutdown();
            }

        }

        private void add_comp_butt_Click(object sender, RoutedEventArgs e)
        {
            CompetitionAddWindow competitionAddWindow = new CompetitionAddWindow();
            this.Close();
            competitionAddWindow.ShowDialog();
        }

        //private void edit_comp_butt_Click(object sender, RoutedEventArgs e)
        //{
        //    CompetitionEditWindow competitionEditWindow = new CompetitionEditWindow();
        //    this.Close();
        //    competitionEditWindow.ShowDialog();
        //}
    }
}
