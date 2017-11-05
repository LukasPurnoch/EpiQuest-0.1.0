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
    public class Attacks : Enemy_Selection
    {
        public int HP1 = 0;
        public int HP2 = 0;

        public void SkrytUtoky(Button Silny_utok, Button Rychly_utok, Button Normalni_utok)
        {
            Silny_utok.Visibility = Visibility.Hidden;
            Rychly_utok.Visibility = Visibility.Hidden;
            Normalni_utok.Visibility = Visibility.Hidden;
        }
        public void ZobrazitUtoky(Button Silny_utok, Button Rychly_utok, Button Normalni_utok)
        {
            Silny_utok.Visibility = Visibility.Visible;
            Rychly_utok.Visibility = Visibility.Visible;
            Normalni_utok.Visibility = Visibility.Visible;
        }

        public void Rychly_Utok(Label CurrentHPEnemy1, Label CurrentHPEnemy2, Label DMGInfo_Pos1, Label DMGInfo_Pos2, int FinalEnemySelect)
        {
            Random RychlyUtok_HitChance = new Random(); // Fast attack -> 80% Chance
            Random RychlyUtok_DMG = new Random(); // 8 - 13 DMG
            int HitChance_RychlyUtok = RychlyUtok_HitChance.Next(1, 101);
            int DMG_RychlyUtok = RychlyUtok_DMG.Next(8, 14);

            if (FinalEnemySelect == 1) // Position Select
            {
                if (HitChance_RychlyUtok <= 80)
                {
                    if (int.TryParse(CurrentHPEnemy1.Content.ToString(), out HP1))
                    {
                        HP1 -= DMG_RychlyUtok;
                        CurrentHPEnemy1.Content = HP1;
                        DMGInfo_Pos1.Content = DMG_RychlyUtok;
                    }
                }

                if (HitChance_RychlyUtok >= 81)
                {
                    DMGInfo_Pos1.Content = "MISS";
                }
            }

            if (FinalEnemySelect == 2) // Position Select
            {
                if (HitChance_RychlyUtok <= 80)
                {
                    if (int.TryParse(CurrentHPEnemy2.Content.ToString(), out HP2))
                    {
                        HP2 -= DMG_RychlyUtok;
                        CurrentHPEnemy2.Content = HP2;
                        DMGInfo_Pos2.Content = DMG_RychlyUtok;
                    }
                }

                if (HitChance_RychlyUtok >= 81)
                {
                    DMGInfo_Pos2.Content = "MISS";
                }
            }
        }

        public void Silny_Utok(Label CurrentHPEnemy1, Label CurrentHPEnemy2, Label DMGInfo_Pos1, Label DMGInfo_Pos2, Label MaxHPEnemy1, Label MaxHPEnemy2, Button Enemy1Attack, Button Enemy2Attack, Image Enemy1, Image Enemy2, Image EnemyPositionM1, Image EnemyPositionM2, int FinalEnemySelect)
        {
            Random SilnyUtok_HitChance = new Random(); // Strong attack -> 30% Chance
            Random SilnyUtok_DMG = new Random(); // 25 - 30 DMG
            int HitChance_SilnyUtok = SilnyUtok_HitChance.Next(1, 101);
            int DMG_SilnyUtok = SilnyUtok_DMG.Next(25, 31);

            if (FinalEnemySelect == 1) // Position Select
            {
                if (HitChance_SilnyUtok <= 30)
                {
                    if (int.TryParse(CurrentHPEnemy1.Content.ToString(), out HP1))
                    {
                        HP1 -= DMG_SilnyUtok;
                        CurrentHPEnemy1.Content = HP1;
                        DMGInfo_Pos1.Content = DMG_SilnyUtok;
                    }
                }

                if (HitChance_SilnyUtok >= 31)
                {
                    DMGInfo_Pos1.Content = "MISS";
                }
            }

            if (FinalEnemySelect == 2) // Position Select
            {
                if (HitChance_SilnyUtok <= 30)
                {
                    if (int.TryParse(CurrentHPEnemy2.Content.ToString(), out HP2))
                    {
                        HP2 -= DMG_SilnyUtok;
                        CurrentHPEnemy2.Content = HP2;
                        DMGInfo_Pos2.Content = DMG_SilnyUtok;
                    }
                }

                if (HitChance_SilnyUtok >= 31)
                {
                    DMGInfo_Pos2.Content = "MISS";
                }
            }
        }

        public void Normalni_Utok(Label CurrentHPEnemy1, Label CurrentHPEnemy2, Label DMGInfo_Pos1, Label DMGInfo_Pos2, Label MaxHPEnemy1, Label MaxHPEnemy2, Button Enemy1Attack, Button Enemy2Attack, Image Enemy1, Image Enemy2, Image EnemyPositionM1, Image EnemyPositionM2, int FinalEnemySelect)
        {
            Random NormalniUtok_HitChance = new Random(); // Normaln attack -> 60% Chance
            Random NormalniUtok_DMG = new Random(); // 14 - 19 DMG
            int HitChance_NormalniUtok = NormalniUtok_HitChance.Next(1, 101);
            int DMG_NormalniUtok = NormalniUtok_DMG.Next(14, 20);

            if (FinalEnemySelect == 1) // Position Select
            {
                if (HitChance_NormalniUtok <= 60)
                {
                    if (int.TryParse(CurrentHPEnemy1.Content.ToString(), out HP1))
                    {
                        HP1 -= DMG_NormalniUtok;
                        CurrentHPEnemy1.Content = HP1;
                        DMGInfo_Pos1.Content = DMG_NormalniUtok;
                    }
                }

                if (HitChance_NormalniUtok >= 61)
                {
                    DMGInfo_Pos1.Content = "MISS";
                }
            }

            if (FinalEnemySelect == 2) // Position Select
            {
                if (HitChance_NormalniUtok <= 60)
                {
                    if (int.TryParse(CurrentHPEnemy2.Content.ToString(), out HP2))
                    {
                        HP2 -= DMG_NormalniUtok;
                        CurrentHPEnemy2.Content = HP2;
                        DMGInfo_Pos2.Content = DMG_NormalniUtok;
                    }
                }

                if (HitChance_NormalniUtok >= 61)
                {
                    DMGInfo_Pos2.Content = "MISS";
                }
            }
        }

    }
}
