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
    /// Логика взаимодействия для TradingEditWindow.xaml
    /// </summary>
    public partial class TradingEditWindow : Window
    {
        public TradingEditWindow()
        {
            InitializeComponent();
        }

        private void trade_add_but_Click(object sender, RoutedEventArgs e)
        {

        }

        private void no_but_Click(object sender, RoutedEventArgs e)
        {
            TradingMainWindow tradingMainWindow = new TradingMainWindow();
            this.Close();
            tradingMainWindow.ShowDialog();
        }
    }
}
