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
    /// Логика взаимодействия для MainHorseWindow.xaml
    /// </summary>
    public partial class MainHorseWindow : Window
    {
        contextEntities context = new contextEntities();
        public MainHorseWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            HorseList.ItemsSource = context.Horses.ToList();
        }

        private void add_horse_butt_Click(object sender, RoutedEventArgs e)
        {
            AddHorseWindow addHorseWindow = new AddHorseWindow();
            this.Close();
            addHorseWindow.ShowDialog();
        }

        private void edit_horse_butt_Click(object sender, RoutedEventArgs e)
        {
            EditHorseWindow editHorseWindow = new EditHorseWindow();
            this.Close();
            editHorseWindow.ShowDialog();
        }

        private void quittomain_but_Click(object sender, RoutedEventArgs e)
        {
            HelloWindow helloWindow = new HelloWindow();
            this.Close();
            helloWindow.ShowDialog();
        }

        private void quitapp_but_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
