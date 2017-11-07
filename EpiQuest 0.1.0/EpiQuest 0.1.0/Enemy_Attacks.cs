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
        public int EnmCount = 0;

        public void Rychly_Utok_E1(Label CurrentHP, Label DMGInfo_Thief, Image Enemy1, Image Enemy2, Image EnemyPositionM1, Image EnemyPositionM2, Label CurrentHPEnemy1, Label CurrentHPEnemy2, Label MaxHPEnemy1, Label MaxHPEnemy2, Button Enemy1Attack, Button Enemy2Attack, Label DMGInfo_Pos1, Label DMGInfo_Pos2)
        {
            Random RychlyE1_HitChance1 = new Random(); // Fast Attack -> 80% Chance, 8-13 DMG
            Random RychlyE1_DMG1 = new Random();
            int HitChance_RychlyE1 = RychlyE1_HitChance1.Next(1, 101);
            int DMG_RychlyE1 = RychlyE1_DMG1.Next(8, 14);

            int.TryParse(CurrentHPEnemy1.Content.ToString(), out int EnemyPos1HP);

            if (EnemyPos1HP > 0)
            {
                if (enemytype1 == 2 || enemytype1 == 5)
                {
                    if (HitChance_RychlyE1 <= 80)
                    {
                        if (int.TryParse(CurrentHP.Content.ToString(), out int Main_HP))
                        {
                            Main_HP -= DMG_RychlyE1;
                            CurrentHP.Content = Main_HP;
                            DMGInfo_Thief.Content = DMG_RychlyE1;
                        }
                    }
                    else
                    {
                        DMGInfo_Thief.Content = "MISS";
                    }
                }
                
            }
            if (EnemyPos1HP <= 0)
            {
                Enemy1.Visibility = Visibility.Hidden;
                EnemyPositionM1.Visibility = Visibility.Hidden;
                CurrentHPEnemy1.Visibility = Visibility.Hidden;
                MaxHPEnemy1.Visibility = Visibility.Hidden;
                Enemy1Attack.Visibility = Visibility.Hidden;
                DMGInfo_Pos1.Visibility = Visibility.Hidden;
                EnmCount += 1;
            }
        }

        public void Rychly_Utok_E2(Label CurrentHP, Label DMGInfo_Thief, Image Enemy1, Image Enemy2, Image EnemyPositionM1, Image EnemyPositionM2, Label CurrentHPEnemy1, Label CurrentHPEnemy2, Label MaxHPEnemy1, Label MaxHPEnemy2, Button Enemy1Attack, Button Enemy2Attack, Label DMGInfo_Pos1, Label DMGInfo_Pos2)
        {
            Random RychlyE2_HitChance2 = new Random(); // Fast Attack -> 80% Chance, 8-13 DMG
            Random RychlyE2_DMG2 = new Random();
            int HitChance_RychlyE2 = RychlyE2_HitChance2.Next(1, 101);
            int DMG_RychlyE2 = RychlyE2_DMG2.Next(8, 14);

            int.TryParse(CurrentHPEnemy2.Content.ToString(), out int EnemyPos2HP);

            if (EnemyPos2HP > 0)
            {
                if (enemytype2 == 2 || enemytype2 == 5)
                {
                    if (HitChance_RychlyE2 <= 80)
                    {
                        if (int.TryParse(CurrentHP.Content.ToString(), out int Main_HP))
                        {
                            Main_HP -= DMG_RychlyE2;
                            CurrentHP.Content = Main_HP;
                            DMGInfo_Thief.Content = DMG_RychlyE2;
                        }
                    }
                    else
                    {
                        DMGInfo_Thief.Content = "MISS";
                    }
                }

            }
            if (EnemyPos2HP <= 0)
            {
                Enemy2.Visibility = Visibility.Hidden;
                EnemyPositionM2.Visibility = Visibility.Hidden;
                CurrentHPEnemy2.Visibility = Visibility.Hidden;
                MaxHPEnemy2.Visibility = Visibility.Hidden;
                Enemy2Attack.Visibility = Visibility.Hidden;
                DMGInfo_Pos2.Visibility = Visibility.Hidden;
                EnmCount += 1;
            }
        }

        public void Silny_Utok_E1(Label CurrentHP, Label DMGInfo_Thief, Image Enemy1, Image Enemy2, Image EnemyPositionM1, Image EnemyPositionM2, Label CurrentHPEnemy1, Label CurrentHPEnemy2, Label MaxHPEnemy1, Label MaxHPEnemy2, Button Enemy1Attack, Button Enemy2Attack, Label DMGInfo_Pos1, Label DMGInfo_Pos2)
        {
            Random StrongE1_HitChance1 = new Random(); // Fast Attack -> 80% Chance, 8-13 DMG
            Random StrongE1_DMG1 = new Random();
            int HitChance_StrongE1 = StrongE1_HitChance1.Next(1, 101);
            int DMG_StrongE1 = StrongE1_DMG1.Next(25, 31);

            int.TryParse(CurrentHPEnemy1.Content.ToString(), out int EnemyPos1HP);

            if (EnemyPos1HP > 0)
            {
                if (enemytype1 == 1 || enemytype1 == 4)
                {
                    if (HitChance_StrongE1 <= 30)
                    {
                        if (int.TryParse(CurrentHP.Content.ToString(), out int Main_HP))
                        {
                            Main_HP -= DMG_StrongE1;
                            CurrentHP.Content = Main_HP;
                            DMGInfo_Thief.Content = DMG_StrongE1;
                        }
                    }
                    else
                    {
                        DMGInfo_Thief.Content = "MISS";
                    }
                }

            }
            if (EnemyPos1HP <= 0)
            {
                Enemy1.Visibility = Visibility.Hidden;
                EnemyPositionM1.Visibility = Visibility.Hidden;
                CurrentHPEnemy1.Visibility = Visibility.Hidden;
                MaxHPEnemy1.Visibility = Visibility.Hidden;
                Enemy1Attack.Visibility = Visibility.Hidden;
                DMGInfo_Pos1.Visibility = Visibility.Hidden;
                EnmCount += 1;
            }
        }

        public void Silny_Utok_E2(Label CurrentHP, Label DMGInfo_Thief, Image Enemy1, Image Enemy2, Image EnemyPositionM1, Image EnemyPositionM2, Label CurrentHPEnemy1, Label CurrentHPEnemy2, Label MaxHPEnemy1, Label MaxHPEnemy2, Button Enemy1Attack, Button Enemy2Attack, Label DMGInfo_Pos1, Label DMGInfo_Pos2)
        {
            Random StrongE2_HitChance2 = new Random(); // Fast Attack -> 80% Chance, 8-13 DMG
            Random StrongE2_DMG2 = new Random();
            int HitChance_StrongE2 = StrongE2_HitChance2.Next(1, 101);
            int DMG_StrongE2 = StrongE2_DMG2.Next(25, 31);

            int.TryParse(CurrentHPEnemy2.Content.ToString(), out int EnemyPos2HP);

            if (EnemyPos2HP > 0)
            {
                if (enemytype2 == 1 || enemytype2 == 4)
                {
                    if (HitChance_StrongE2 <= 80)
                    {
                        if (int.TryParse(CurrentHP.Content.ToString(), out int Main_HP))
                        {
                            Main_HP -= DMG_StrongE2;
                            CurrentHP.Content = Main_HP;
                            DMGInfo_Thief.Content = DMG_StrongE2;
                        }
                    }
                    else
                    {
                        DMGInfo_Thief.Content = "MISS";
                    }
                }

            }
            if (EnemyPos2HP <= 0)
            {
                Enemy2.Visibility = Visibility.Hidden;
                EnemyPositionM2.Visibility = Visibility.Hidden;
                CurrentHPEnemy2.Visibility = Visibility.Hidden;
                MaxHPEnemy2.Visibility = Visibility.Hidden;
                Enemy2Attack.Visibility = Visibility.Hidden;
                DMGInfo_Pos2.Visibility = Visibility.Hidden;
                EnmCount += 1;
            }
        }

        public void Normalni_Utok_E1(Label CurrentHP, Label DMGInfo_Thief, Image Enemy1, Image Enemy2, Image EnemyPositionM1, Image EnemyPositionM2, Label CurrentHPEnemy1, Label CurrentHPEnemy2, Label MaxHPEnemy1, Label MaxHPEnemy2, Button Enemy1Attack, Button Enemy2Attack, Label DMGInfo_Pos1, Label DMGInfo_Pos2)
        {
            Random NormalniE1_HitChance1 = new Random(); // Fast Attack -> 80% Chance, 8-13 DMG
            Random NormalniE1_DMG1 = new Random();
            int HitChance_NormalniE1 = NormalniE1_HitChance1.Next(1, 101);
            int DMG_NormalniE1 = NormalniE1_DMG1.Next(14, 20);

            int.TryParse(CurrentHPEnemy1.Content.ToString(), out int EnemyPos1HP);

            if (EnemyPos1HP > 0)
            {
                if (enemytype1 == 3)
                {
                    if (HitChance_NormalniE1 <= 60)
                    {
                        if (int.TryParse(CurrentHP.Content.ToString(), out int Main_HP))
                        {
                            Main_HP -= DMG_NormalniE1;
                            CurrentHP.Content = Main_HP;
                            DMGInfo_Thief.Content = DMG_NormalniE1;
                        }
                    }
                    else
                    {
                        DMGInfo_Thief.Content = "MISS";
                    }
                }

            }
            if (EnemyPos1HP <= 0)
            {
                Enemy1.Visibility = Visibility.Hidden;
                EnemyPositionM1.Visibility = Visibility.Hidden;
                CurrentHPEnemy1.Visibility = Visibility.Hidden;
                MaxHPEnemy1.Visibility = Visibility.Hidden;
                Enemy1Attack.Visibility = Visibility.Hidden;
                DMGInfo_Pos1.Visibility = Visibility.Hidden;
                EnmCount += 1;
            }
        }

        public void Normalni_Utok_E2(Label CurrentHP, Label DMGInfo_Thief, Image Enemy1, Image Enemy2, Image EnemyPositionM1, Image EnemyPositionM2, Label CurrentHPEnemy1, Label CurrentHPEnemy2, Label MaxHPEnemy1, Label MaxHPEnemy2, Button Enemy1Attack, Button Enemy2Attack, Label DMGInfo_Pos1, Label DMGInfo_Pos2)
        {
            Random NormalniE2_HitChance2 = new Random(); // Fast Attack -> 80% Chance, 8-13 DMG
            Random NormalniE2_DMG2 = new Random();
            int HitChance_NormalniE2 = NormalniE2_HitChance2.Next(1, 101);
            int DMG_NormalniE2 = NormalniE2_DMG2.Next(14, 20);

            int.TryParse(CurrentHPEnemy2.Content.ToString(), out int EnemyPos2HP);

            if (EnemyPos2HP > 0)
            {
                if (enemytype2 == 3)
                {
                    if (HitChance_NormalniE2 <= 80)
                    {
                        if (int.TryParse(CurrentHP.Content.ToString(), out int Main_HP))
                        {
                            Main_HP -= DMG_NormalniE2;
                            CurrentHP.Content = Main_HP;
                            DMGInfo_Thief.Content = DMG_NormalniE2;
                        }
                    }
                    else
                    {
                        DMGInfo_Thief.Content = "MISS";
                    }
                }

            }
            if (EnemyPos2HP <= 0)
            {
                Enemy2.Visibility = Visibility.Hidden;
                EnemyPositionM2.Visibility = Visibility.Hidden;
                CurrentHPEnemy2.Visibility = Visibility.Hidden;
                MaxHPEnemy2.Visibility = Visibility.Hidden;
                Enemy2Attack.Visibility = Visibility.Hidden;
                DMGInfo_Pos2.Visibility = Visibility.Hidden;
                EnmCount += 1;
            }
        }

    }
}
