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
    class CaveType
    {
        public int cavetyp;

        public void RandomCaveType(ImageBrush Background)
        {
            Random cave = new Random();
            cavetyp = cave.Next(1, 6);


        }
    }
}
