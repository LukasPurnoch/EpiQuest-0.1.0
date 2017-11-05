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
    public class CaveType
    {
        public static int cavetyp;

        public void RandomCaveType(ImageBrush Background)
        {
            Random cave = new Random();
            cavetyp = cave.Next(1, 2); //6

            if (cavetyp == 1)
            {
                Background.ImageSource = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Places/Forest.png"));
            }
            else if (cavetyp == 2)
            {
                Background.ImageSource = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Places/Cave.png"));
            }
            else if (cavetyp == 3)
            {
                Background.ImageSource = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Places/Catacombs.png"));
            }
            else if (cavetyp == 4)
            {
                Background.ImageSource = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Places/Dungeon.png"));
            }
            else if (cavetyp == 5)
            {
                Background.ImageSource = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Places/Depths.png"));
            }
        }
    }
}
