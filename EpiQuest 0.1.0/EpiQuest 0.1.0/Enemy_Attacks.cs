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

        public void Rychly_Utok_E(Label CurrentHP, Label DMGInfo_Thief, Image Enemy1, Image Enemy2, Image EnemyPositionM1, Image EnemyPositionM2, Label CurrentHPEnemy1, Label CurrentHPEnemy2, Label MaxHPEnemy1, Label MaxHPEnemy2, Button Enemy1Attack, Button Enemy2Attack)
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

                if(HPM <= 0)
                {
                    //
                }
            }  
        }

        public void Silny_Utok_E(Label CurrentHP, Label DMGInfo_Thief, Image Enemy1, Image Enemy2, Image EnemyPositionM1, Image EnemyPositionM2, Label CurrentHPEnemy1, Label CurrentHPEnemy2, Label MaxHPEnemy1, Label MaxHPEnemy2, Button Enemy1Attack, Button Enemy2Attack)
        {
            if (cavetyp == 1 && enemytype1 == 1 || enemytype2 == 1 || enemytype1 == 4 || enemytype2 == 4)
            {

            }
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

        public void Normalni_Utok_E(Label CurrentHP, Label DMGInfo_Thief, Image Enemy1, Image Enemy2, Image EnemyPositionM1, Image EnemyPositionM2, Label CurrentHPEnemy1, Label CurrentHPEnemy2, Label MaxHPEnemy1, Label MaxHPEnemy2, Button Enemy1Attack, Button Enemy2Attack)
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
