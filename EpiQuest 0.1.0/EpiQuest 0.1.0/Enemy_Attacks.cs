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
    class Enemy_Attacks : Enemy_Selection
    {
        public int HPM = 0;

        public void Rychly_Utok_E(Label CurrentHP, Label DMGInfo_Thief, Image Enemy1, Image Enemy2, Image EnemyPositionM1, Image EnemyPositionM2, Label CurrentHPEnemy1, Label CurrentHPEnemy2, Label MaxHPEnemy1, Label MaxHPEnemy2, Button Enemy1Attack, Button Enemy2Attack, Label DMGInfo_Pos1, Label DMGInfo_Pos2)
        {
            int.TryParse(CurrentHPEnemy1.Content.ToString(), out int CHP1);
            int.TryParse(CurrentHPEnemy2.Content.ToString(), out int CHP2);

            if (CHP1 > 0 || CHP2 > 0 )
            {
                if (cavetyp == 1 && enemytype1 == 2 || enemytype2 == 2 || enemytype1 == 5 || enemytype2 == 5)
                {
                    Random EnemyFast_HitChance = new Random(); // Fast attack -> 80% Chance
                    Random EnemyFast_DMG = new Random(); // 8 - 13 DMG
                    int HitChance_EnemyFast = EnemyFast_HitChance.Next(1, 101);
                    int DMG_EnemyFast = EnemyFast_DMG.Next(8, 14);

                    if (HitChance_EnemyFast <= 80)
                    {
                        if (int.TryParse(CurrentHP.Content.ToString(), out HPM))
                        {
                            HPM -= DMG_EnemyFast;
                            CurrentHP.Content = HPM;
                            DMGInfo_Thief.Content = DMG_EnemyFast;
                        }
                    }

                    if (HitChance_EnemyFast >= 81)
                    {
                        DMGInfo_Thief.Content = "MISS";
                    }
                    if (CHP1 <= 0 && enemytype1 == 2 || enemytype1 == 5)
                    {
                        Enemy1.Visibility = Visibility.Hidden;
                        EnemyPositionM1.Visibility = Visibility.Hidden;
                        CurrentHPEnemy1.Visibility = Visibility.Hidden;
                        MaxHPEnemy1.Visibility = Visibility.Hidden;
                        Enemy1Attack.Visibility = Visibility.Hidden;
                        DMGInfo_Pos1.Visibility = Visibility.Hidden;
                    }
                    if (CHP2 <= 0 && enemytype2 == 2 || enemytype2 == 5)
                    {
                        Enemy2.Visibility = Visibility.Hidden;
                        EnemyPositionM2.Visibility = Visibility.Hidden;
                        CurrentHPEnemy2.Visibility = Visibility.Hidden;
                        MaxHPEnemy2.Visibility = Visibility.Hidden;
                        Enemy2Attack.Visibility = Visibility.Hidden;
                        DMGInfo_Pos2.Visibility = Visibility.Hidden;
                    }
                }

            
            }  
        }

        public void Silny_Utok_E(Label CurrentHP, Label DMGInfo_Thief, Image Enemy1, Image Enemy2, Image EnemyPositionM1, Image EnemyPositionM2, Label CurrentHPEnemy1, Label CurrentHPEnemy2, Label MaxHPEnemy1, Label MaxHPEnemy2, Button Enemy1Attack, Button Enemy2Attack)
        {
            if (cavetyp == 1 && enemytype1 == 1 || enemytype2 == 1 || enemytype1 == 4 || enemytype2 == 4)
            {
                Random SilnyUtokE_HitChance = new Random(); // Strong attack -> 80% Chance
                Random SilnyUtokE_DMG = new Random(); // 25 - 30 DMG
                int HitChance_SilnyUtokE = SilnyUtokE_HitChance.Next(1, 101);
                int DMG_SilnyUtokE = SilnyUtokE_DMG.Next(25, 31);

                if (HitChance_SilnyUtokE <= 30)
                {
                    if (int.TryParse(CurrentHP.Content.ToString(), out HPM))
                    {
                        HPM -= DMG_SilnyUtokE;
                        CurrentHP.Content = HPM;
                        DMGInfo_Thief.Content = DMG_SilnyUtokE;
                    }
                }

                if (HitChance_SilnyUtokE >= 31)
                {
                    DMGInfo_Thief.Content = "MISS";
                }
            }
            
        }

        public void Normalni_Utok_E(Label CurrentHP, Label DMGInfo_Thief, Image Enemy1, Image Enemy2, Image EnemyPositionM1, Image EnemyPositionM2, Label CurrentHPEnemy1, Label CurrentHPEnemy2, Label MaxHPEnemy1, Label MaxHPEnemy2, Button Enemy1Attack, Button Enemy2Attack)
        {
            if (cavetyp == 1 && enemytype1 == 3 || enemytype2 == 3)
            {
                Random NormalniUtokE_HitChance = new Random(); // Normal attack -> 80% Chance
                Random NormalniUtokE_DMG = new Random(); // 14 - 20 DMG
                int HitChance_NormalniUtokE = NormalniUtokE_HitChance.Next(1, 101);
                int DMG_NormalniUtokE = NormalniUtokE_DMG.Next(14, 21);

                if (HitChance_NormalniUtokE <= 60)
                {
                    if (int.TryParse(CurrentHP.Content.ToString(), out HPM))
                    {
                        HPM -= DMG_NormalniUtokE;
                        CurrentHP.Content = HPM;
                        DMGInfo_Thief.Content = DMG_NormalniUtokE;
                    }
                }

                if (HitChance_NormalniUtokE >= 61)
                {
                    DMGInfo_Thief.Content = "MISS";
                }
            }
            
        }
        
    }
}
