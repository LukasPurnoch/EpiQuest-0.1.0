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
    public class Attacks_1
    {
        public void ch(Button Silny_utok)
        {
            Silny_utok.Content = 45;
        }

        public void SkrytUtoky(Button Silny_utok, Button Rychly_utok, Button Normalni_utok)
        {
            Silny_utok.Visibility = Visibility.Hidden;
            Rychly_utok.Visibility = Visibility.Hidden;
            Normalni_utok.Visibility = Visibility.Hidden;
        }

        public void Rychly_Utok_1()
        {

        }
    }
}
