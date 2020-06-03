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
    /// Логика взаимодействия для TradingAddWindow.xaml
    /// </summary>
    public partial class TradingAddWindow : Window
    {
        contextEntities context = new contextEntities();
        public TradingAddWindow()
        {
            InitializeComponent();
        }

        private void trade_add_but_Click(object sender, RoutedEventArgs e)
        {
            context.Trading.Add(new Trading
            {
                idTrade = id_trade_box.Text,
                TradeDateTime = (DateTime)date_trade_box.SelectedDate,
                idStaff = staff_trade_box.SelectedIndex,
                Price = price_trade_box.Text


            });
            context.SaveChanges();
            MessageBox.Show("Сделка добавлена в систему", "", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void no_but_Click(object sender, RoutedEventArgs e)
        {
            TradingMainWindow tradingMainWindow = new TradingMainWindow();
            this.Close();
            tradingMainWindow.ShowDialog();
        }
    }
}
