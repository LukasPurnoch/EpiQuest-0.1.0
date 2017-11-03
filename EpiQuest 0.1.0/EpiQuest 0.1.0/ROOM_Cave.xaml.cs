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
    /// Interakční logika pro ROOM_Cave.xaml
    /// </summary>
    public partial class ROOM_Cave : Page
    {
        public ROOM_Cave()
        {
            InitializeComponent();

            Attacks_1 attack1 = new Attacks_1();
            CaveType cavetype = new CaveType();
        }

        private void Silny_utok_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Rychly_utok_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Normalni_utok_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Enemy1Attack_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Enemy2Attack_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
