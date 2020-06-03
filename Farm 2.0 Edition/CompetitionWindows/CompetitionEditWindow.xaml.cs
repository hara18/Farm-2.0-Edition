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
    /// Логика взаимодействия для CompetitionEditWindow.xaml
    /// </summary>
    public partial class CompetitionEditWindow : Window
    {
        public CompetitionEditWindow()
        {
            InitializeComponent();
        }

        private void comp_edit_but_Click(object sender, RoutedEventArgs e)
        {

        }

        private void no_but_Click(object sender, RoutedEventArgs e)
        {
            CompetitionMainWindow competitionMainWindow = new CompetitionMainWindow();
            this.Close();
            competitionMainWindow.ShowDialog();
        }
    }
}
