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

namespace Farm_2._0_Edition.TradingWindows
{
    /// <summary>
    /// Логика взаимодействия для TradingMainWindow.xaml
    /// </summary>
    public partial class TradingMainWindow : Window
    {
        contextEntities context = new contextEntities();

        public TradingMainWindow()
        {
            InitializeComponent();
        }


        private void quitapp_but_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void quittomain_but_Click(object sender, RoutedEventArgs e)
        {
            HelloWindow helloWindow = new HelloWindow();
            this.Close();
            helloWindow.ShowDialog();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)


        {
            tradeList.ItemsSource = context.Trading.ToList();


        }



        private void add_trade_butt_Click(object sender, RoutedEventArgs e)
        {
            TradingAddWindow tradingAddWindow = new TradingAddWindow();
            this.Close();
            tradingAddWindow.ShowDialog();
        }


    }
}

