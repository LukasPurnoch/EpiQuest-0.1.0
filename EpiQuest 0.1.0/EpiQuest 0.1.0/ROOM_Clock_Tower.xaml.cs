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
using System.Threading;

namespace EpiQuest_0._1._0
{
    /// <summary>
    /// Interakční logika pro ROOM_Clock_Tower.xaml
    /// </summary>
    public partial class ROOM_Clock_Tower : Page
    {
        public ROOM_Clock_Tower()
        {
            InitializeComponent();
        }


        private void CTNBT1_Click(object sender, RoutedEventArgs e)
        {
            TXT1.Visibility = Visibility.Hidden;
            TXT2.Visibility = Visibility.Visible;
            CTNBT1.Visibility = Visibility.Hidden;
            CTNBT2.Visibility = Visibility.Visible;
        }
        private void CTNBT2_Click(object sender, RoutedEventArgs e)
        {
            TXT2.Visibility = Visibility.Hidden;
            TXT3.Visibility = Visibility.Visible;
            CTNBT2.Visibility = Visibility.Hidden;
            CTNBT3.Visibility = Visibility.Visible;
        }
        private void CTNBT3_Click(object sender, RoutedEventArgs e)
        {
            //STORY.Content = new ROOM_Cave();
        }
    }
}