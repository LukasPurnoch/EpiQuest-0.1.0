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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EpiQuest_0._1._0
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NovaHra(object sender, RoutedEventArgs e)
        {
            MENU1.Content = new ROOM_Clock_Tower();
        }

        private void NacistHru(object sender, RoutedEventArgs e)
        {
            MENU2.Content = new ROOM_Cave();
        }

        private void UkoncitHru(object sender, RoutedEventArgs e)
        {

        }
    }
}
