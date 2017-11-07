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
    public class Enemy_Selection : CaveType
    {
        public static int enemytype1; 
        public static int enemytype2;
        public static int CAVE_TYP = cavetyp;

        public void EnemySelect(Image Enemy1, Image Enemy2, Image EnemyPositionM1, Image EnemyPositionM2, Label CurrentHPEnemy1, Label MaxHPEnemy1, Label CurrentHPEnemy2, Label MaxHPEnemy2)
        {
            Random EnemyType = new Random();
            enemytype1 = EnemyType.Next(1, 6);
            enemytype2 = EnemyType.Next(1, 6);
            
            if (cavetyp == 1)
            {
                if (enemytype1 == 1)
                {
                    Enemy1.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Hundlegs.png"));
                    EnemyPositionM1.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Hundlegs.png"));

                    CurrentHPEnemy1.Content = 45;
                    MaxHPEnemy1.Content = "/ 45";
                }
                if (enemytype2 == 1)
                {
                    Enemy2.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Hundlegs.png"));
                    EnemyPositionM2.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Hundlegs.png"));

                    CurrentHPEnemy2.Content = 45;
                    MaxHPEnemy2.Content = "/ 45";
                }
                if (enemytype1 == 2)
                {
                    Enemy1.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Gigantoad.png"));
                    EnemyPositionM1.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Gigantoad.png"));

                    CurrentHPEnemy1.Content = 35;
                    MaxHPEnemy1.Content = "/ 35";
                }
                if (enemytype2 == 2)
                {
                    Enemy2.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Gigantoad.png"));
                    EnemyPositionM2.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Gigantoad.png"));

                    CurrentHPEnemy2.Content = 35;
                    MaxHPEnemy2.Content = "/ 35";
                }
                if (enemytype1 == 3)
                {
                    Enemy1.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Death_Flower.png"));
                    EnemyPositionM1.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Death_Flower.png"));

                    CurrentHPEnemy1.Content = 45;
                    MaxHPEnemy1.Content = "/ 45";
                }
                if (enemytype2 == 3)
                {
                    Enemy2.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Death_Flower.png"));
                    EnemyPositionM2.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Death_Flower.png"));

                    CurrentHPEnemy2.Content = 45;
                    MaxHPEnemy2.Content = "/ 45";
                }
                if (enemytype1 == 4)
                {
                    Enemy1.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Blood_Flower.png"));
                    EnemyPositionM1.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Blood_Flower.png"));

                    CurrentHPEnemy1.Content = 50;
                    MaxHPEnemy1.Content = "/ 50";
                }
                if (enemytype2 == 4)
                {
                    Enemy2.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Blood_Flower.png"));
                    EnemyPositionM2.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Blood_Flower.png"));

                    CurrentHPEnemy2.Content = 50;
                    MaxHPEnemy2.Content = "/ 50";
                }
                if (enemytype1 == 5)
                {
                    Enemy1.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Flying_Eyes.png"));
                    EnemyPositionM1.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Flying_Eyes.png"));

                    CurrentHPEnemy1.Content = 30;
                    MaxHPEnemy1.Content = "/ 30";
                }
                if (enemytype2 == 5)
                {
                    Enemy2.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Flying_Eyes.png"));
                    EnemyPositionM2.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Flying_Eyes.png"));

                    CurrentHPEnemy2.Content = 30;
                    MaxHPEnemy2.Content = "/ 30";
                }
            }

            if (cavetyp == 2)
            {
                if (enemytype1 == 1)
                {
                    Enemy1.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Ghoul.png"));
                    EnemyPositionM1.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Ghoul.png"));

                    CurrentHPEnemy1.Content = 50;
                    MaxHPEnemy1.Content = "/ 50";
                }
                if (enemytype2 == 1)
                {
                    Enemy2.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Ghoul.png"));
                    EnemyPositionM2.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Ghoul.png"));

                    CurrentHPEnemy2.Content = 50;
                    MaxHPEnemy2.Content = "/ 50";
                }
                if (enemytype1 == 2)
                {
                    Enemy1.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Lilith.png"));
                    EnemyPositionM1.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Lilith.png"));

                    CurrentHPEnemy1.Content = 45;
                    MaxHPEnemy1.Content = "/ 45";
                }
                if (enemytype2 == 2)
                {
                    Enemy2.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Lilith.png"));
                    EnemyPositionM2.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Lilith.png"));

                    CurrentHPEnemy2.Content = 45;
                    MaxHPEnemy2.Content = "/ 45";
                }
                if (enemytype1 == 3)
                {
                    Enemy1.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Hydra.png"));
                    EnemyPositionM1.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Hydra.png"));

                    CurrentHPEnemy1.Content = 50;
                    MaxHPEnemy1.Content = "/ 50";
                }
                if (enemytype2 == 3)
                {
                    Enemy2.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Hydra.png"));
                    EnemyPositionM2.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Hydra.png"));

                    CurrentHPEnemy2.Content = 50;
                    MaxHPEnemy2.Content = "/ 50";
                }
                if (enemytype1 == 4)
                {
                    Enemy1.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Stone_Golem.png"));
                    EnemyPositionM1.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Stone_Golem.png"));

                    CurrentHPEnemy1.Content = 60;
                    MaxHPEnemy1.Content = "/ 60";
                }
                if (enemytype2 == 4)
                {
                    Enemy2.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Stone_Golem.png"));
                    EnemyPositionM2.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Stone_Golem.png"));

                    CurrentHPEnemy2.Content = 60;
                    MaxHPEnemy2.Content = "/ 60";
                }
                if (enemytype1 == 5)
                {
                    Enemy1.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Arachne.png"));
                    EnemyPositionM1.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Arachne.png"));

                    CurrentHPEnemy1.Content = 40;
                    MaxHPEnemy1.Content = "/ 40";
                }
                if (enemytype2 == 5)
                {
                    Enemy2.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Arachne.png"));
                    EnemyPositionM2.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Arachne.png"));

                    CurrentHPEnemy2.Content = 40;
                    MaxHPEnemy2.Content = "/ 40";
                }
            }

            if (cavetyp == 3)
            {
                if (enemytype1 == 1)
                {
                    Enemy1.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Ghost_Knight.png"));
                    EnemyPositionM1.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Ghost_Knight.png"));

                    CurrentHPEnemy1.Content = 45;
                    MaxHPEnemy1.Content = "/ 45";
                }
                if (enemytype2 == 1)
                {
                    Enemy2.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Ghost_Knight.png"));
                    EnemyPositionM2.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Ghost_Knight.png"));

                    CurrentHPEnemy2.Content = 45;
                    MaxHPEnemy2.Content = "/ 45";
                }
                if (enemytype1 == 2)
                {
                    Enemy1.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Chimera.png"));
                    EnemyPositionM1.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Chimera.png"));

                    CurrentHPEnemy1.Content = 60;
                    MaxHPEnemy1.Content = "/ 60";
                }
                if (enemytype2 == 2)
                {
                    Enemy2.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Chimera.png"));
                    EnemyPositionM2.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Chimera.png"));

                    CurrentHPEnemy2.Content = 60;
                    MaxHPEnemy2.Content = "/ 60";
                }
                if (enemytype1 == 3)
                {
                    Enemy1.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Great_Malboro.png"));
                    EnemyPositionM1.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Great_Malboro.png"));

                    CurrentHPEnemy1.Content = 40;
                    MaxHPEnemy1.Content = "/ 40";
                }
                if (enemytype2 == 3)
                {
                    Enemy2.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Great_Malboro.png"));
                    EnemyPositionM2.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Great_Malboro.png"));

                    CurrentHPEnemy2.Content = 40;
                    MaxHPEnemy2.Content = "/ 40";
                }
                if (enemytype1 == 4)
                {
                    Enemy1.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Fiery_Hound.png"));
                    EnemyPositionM1.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Fiery_Hound.png"));

                    CurrentHPEnemy1.Content = 30;
                    MaxHPEnemy1.Content = "/ 30";
                }
                if (enemytype2 == 4)
                {
                    Enemy2.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Fiery_Hound.png"));
                    EnemyPositionM2.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Fierye_Hound.png"));

                    CurrentHPEnemy2.Content = 30;
                    MaxHPEnemy2.Content = "/ 30";
                }
                if (enemytype1 == 5)
                {
                    Enemy1.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Wicked_Mask.png"));
                    EnemyPositionM1.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Wicked_Mask.png"));

                    CurrentHPEnemy1.Content = 65;
                    MaxHPEnemy1.Content = "/ 65";
                }
                if (enemytype2 == 5)
                {
                    Enemy2.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Wicked_Mask.png"));
                    EnemyPositionM2.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Wicked_Mask.png"));

                    CurrentHPEnemy2.Content = 65;
                    MaxHPEnemy2.Content = "/ 65";
                }
            }

            if (cavetyp == 4)
            {
                if (enemytype1 == 1)
                {
                    Enemy1.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Behemoth.png"));
                    EnemyPositionM1.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Behemoth.png"));

                    CurrentHPEnemy1.Content = 60;
                    MaxHPEnemy1.Content = "/ 60";
                }
                if (enemytype2 == 1)
                {
                    Enemy2.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Behemoth.png"));
                    EnemyPositionM2.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Behemoth.png"));

                    CurrentHPEnemy2.Content = 60;
                    MaxHPEnemy2.Content = "/ 60";
                }
                if (enemytype1 == 2)
                {
                    Enemy1.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Magic_Dragon.png"));
                    EnemyPositionM1.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Magic_Dragon.png"));

                    CurrentHPEnemy1.Content = 35;
                    MaxHPEnemy1.Content = "/ 35";
                }
                if (enemytype2 == 2)
                {
                    Enemy2.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Magic_Dragon.png"));
                    EnemyPositionM2.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Magic_Dragon.png"));

                    CurrentHPEnemy2.Content = 35;
                    MaxHPEnemy2.Content = "/ 35";
                }
                if (enemytype1 == 3)
                {
                    Enemy1.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Brachioraidos.png"));
                    EnemyPositionM1.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Brachioraidos.png"));

                    CurrentHPEnemy1.Content = 65;
                    MaxHPEnemy1.Content = "/ 65";
                }
                if (enemytype2 == 3)
                {
                    Enemy2.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Brachioraidos.png"));
                    EnemyPositionM2.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Brachioraidos.png"));

                    CurrentHPEnemy2.Content = 65;
                    MaxHPEnemy2.Content = "/ 65";
                }
                if (enemytype1 == 4)
                {
                    Enemy1.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Red_Dragon.png"));
                    EnemyPositionM1.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Red_Dragon.png"));

                    CurrentHPEnemy1.Content = 50;
                    MaxHPEnemy1.Content = "/ 50";
                }
                if (enemytype2 == 4)
                {
                    Enemy2.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Red_Dragon.png"));
                    EnemyPositionM2.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Red_Dragon.png"));

                    CurrentHPEnemy2.Content = 50;
                    MaxHPEnemy2.Content = "/ 50";
                }
                if (enemytype1 == 5)
                {
                    Enemy1.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Trap_Door.png"));
                    EnemyPositionM1.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Trap_Door.png"));

                    CurrentHPEnemy1.Content = 70;
                    MaxHPEnemy1.Content = "/ 70";
                }
                if (enemytype2 == 5)
                {
                    Enemy2.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Trap_Door.png"));
                    EnemyPositionM2.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Trap_Door.png"));

                    CurrentHPEnemy2.Content = 70;
                    MaxHPEnemy2.Content = "/ 70";
                }
            }

            if (cavetyp == 5)
            {
                if (enemytype1 == 1)
                {
                    Enemy1.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Death_Puppet.png"));
                    EnemyPositionM1.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Death_Puppet.png"));

                    CurrentHPEnemy1.Content = 50;
                    MaxHPEnemy1.Content = "/ 50";
                }
                if (enemytype2 == 1)
                {
                    Enemy2.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Death_Puppet.png"));
                    EnemyPositionM2.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Death_Puppet.png"));

                    CurrentHPEnemy2.Content = 50;
                    MaxHPEnemy2.Content = "/ 50";
                }
                if (enemytype1 == 2)
                {
                    Enemy1.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Eukaryote.png"));
                    EnemyPositionM1.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Eukaryote.png"));

                    CurrentHPEnemy1.Content = 25;
                    MaxHPEnemy1.Content = "/ 25";
                }
                if (enemytype2 == 2)
                {
                    Enemy2.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Eukaryote.png"));
                    EnemyPositionM2.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Eukaryote.png"));

                    CurrentHPEnemy2.Content = 25;
                    MaxHPEnemy2.Content = "/ 25";
                }
                if (enemytype1 == 3)
                {
                    Enemy1.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Gorgon.png"));
                    EnemyPositionM1.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Gorgon.png"));

                    CurrentHPEnemy1.Content = 30;
                    MaxHPEnemy1.Content = "/ 30";
                }
                if (enemytype2 == 3)
                {
                    Enemy2.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Gorgon.png"));
                    EnemyPositionM2.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Gorgon.png"));

                    CurrentHPEnemy2.Content = 30;
                    MaxHPEnemy2.Content = "/ 30";
                }
                if (enemytype1 == 4)
                {
                    Enemy1.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Black_Knigh.png"));
                    EnemyPositionM1.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Black_Knight.png"));

                    CurrentHPEnemy1.Content = 55;
                    MaxHPEnemy1.Content = "/ 55";
                }
                if (enemytype2 == 4)
                {
                    Enemy2.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Black_Knigh.png"));
                    EnemyPositionM2.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Black_Knight.png"));

                    CurrentHPEnemy2.Content = 55;
                    MaxHPEnemy2.Content = "/ 55";
                }
                if (enemytype1 == 5)
                {
                    Enemy1.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Catoblepas.png"));
                    EnemyPositionM1.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Catoblepas.png"));

                    CurrentHPEnemy1.Content = 45;
                    MaxHPEnemy1.Content = "/ 45";
                }
                if (enemytype2 == 5)
                {
                    Enemy2.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Catoblepas.png"));
                    EnemyPositionM2.Source = new BitmapImage(new Uri("C:/Users/Kiro/Source/Repos/EpiQuest-0.1.0/EpiQuest 0.1.0/EpiQuest 0.1.0/Assets/Characters/Catoblepas.png"));

                    CurrentHPEnemy2.Content = 45;
                    MaxHPEnemy2.Content = "/ 45";
                }
            }
        }
    }
}
