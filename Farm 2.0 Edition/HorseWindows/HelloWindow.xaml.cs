using Farm_2._0_Edition.CompetitionWindows;
using Farm_2._0_Edition.HorseWindows;
using Farm_2._0_Edition.StaffWindows;
using Farm_2._0_Edition.TradingWindows;
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

namespace Farm_2._0_Edition
{
    /// <summary>
    /// Логика взаимодействия для HelloWindow.xaml
    /// </summary>
    public partial class HelloWindow : Window
    {
        contextEntities context = new contextEntities();
        public HelloWindow()
        {
            InitializeComponent();
        }

        private void quittomain_but_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.ShowDialog();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {


            HorseList.ItemsSource = context.Horses.ToList();

        }

        private void quitapp_but_Click(object sender, RoutedEventArgs e)
        {
            {
                Application.Current.Shutdown();
            }

        }



        private void competition_info_butt_Click(object sender, RoutedEventArgs e)
        {
            CompetitionMainWindow competitionMainWindow = new CompetitionMainWindow();
            this.Close();
            competitionMainWindow.ShowDialog();
        }

        private void staff_info_butt_Click(object sender, RoutedEventArgs e)
        {
            StaffMainWindow staffMainWindow = new StaffMainWindow();
            this.Close();
            staffMainWindow.ShowDialog();

        }

        private void horse_info_butt_Click(object sender, RoutedEventArgs e)
        {
            MainHorseWindow mainHorseWindow = new MainHorseWindow();
            this.Close();
            mainHorseWindow.ShowDialog();
        }

        private void trade_info_butt_Click(object sender, RoutedEventArgs e)
        {
            TradingMainWindow tradingMainWindow = new TradingMainWindow();
            this.Close();
            tradingMainWindow.ShowDialog();
        }
    }
}
