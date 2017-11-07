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
    /// Interakční logika pro ROOM_Cave.xaml.cs
    /// </summary>
    public partial class ROOM_Cave : Page
    {
        public int EnemySelectt = 0;
        public int EnemyCount;

        public ROOM_Cave()
        {
            InitializeComponent();
            
            LEVEL();
        }

        public void LEVEL()
        {
            Attacks attack = new Attacks();
            CaveType cavetype = new CaveType();
            Enemy_Selection enemy_selection = new Enemy_Selection();

            attack.SkrytUtoky(Silny_utok, Rychly_utok, Normalni_utok);
            cavetype.RandomCaveType(Background);
            enemy_selection.EnemySelect(Enemy1, Enemy2, EnemyPositionM1, EnemyPositionM2, CurrentHPEnemy1, MaxHPEnemy1, CurrentHPEnemy2, MaxHPEnemy2);
        }

        private void Silny_utok_Click(object sender, RoutedEventArgs e)
        {
            Attacks attack = new Attacks();
            Enemy_Attacks eattack = new Enemy_Attacks();

            attack.Silny_Utok(CurrentHPEnemy1, CurrentHPEnemy2, DMGInfo_Pos1, DMGInfo_Pos2, EnemySelectt);

            if (EnemySelectt == 1)
            {
                eattack.Rychly_Utok_E1(CurrentHP, DMGInfo_Thief, Enemy1, Enemy2, EnemyPositionM1, EnemyPositionM2, CurrentHPEnemy1, CurrentHPEnemy2, MaxHPEnemy1, MaxHPEnemy2, Enemy1Attack, Enemy2Attack, DMGInfo_Pos1, DMGInfo_Pos2);
                eattack.Silny_Utok_E1(CurrentHP, DMGInfo_Thief, Enemy1, Enemy2, EnemyPositionM1, EnemyPositionM2, CurrentHPEnemy1, CurrentHPEnemy2, MaxHPEnemy1, MaxHPEnemy2, Enemy1Attack, Enemy2Attack, DMGInfo_Pos1, DMGInfo_Pos2);
                eattack.Normalni_Utok_E1(CurrentHP, DMGInfo_Thief, Enemy1, Enemy2, EnemyPositionM1, EnemyPositionM2, CurrentHPEnemy1, CurrentHPEnemy2, MaxHPEnemy1, MaxHPEnemy2, Enemy1Attack, Enemy2Attack, DMGInfo_Pos1, DMGInfo_Pos2);

                if (int.TryParse(CurrentHPEnemy1.Content.ToString(), out int E1HP))
                {
                    if (E1HP < 0)
                    {
                        EnemyCount += 1;
                    }
                    if (E1HP >= 2)
                    {
                        LEVEL();
                    }
                }
            }
            else
            {
                eattack.Rychly_Utok_E2(CurrentHP, DMGInfo_Thief, Enemy1, Enemy2, EnemyPositionM1, EnemyPositionM2, CurrentHPEnemy1, CurrentHPEnemy2, MaxHPEnemy1, MaxHPEnemy2, Enemy1Attack, Enemy2Attack, DMGInfo_Pos1, DMGInfo_Pos2);
                eattack.Silny_Utok_E2(CurrentHP, DMGInfo_Thief, Enemy1, Enemy2, EnemyPositionM1, EnemyPositionM2, CurrentHPEnemy1, CurrentHPEnemy2, MaxHPEnemy1, MaxHPEnemy2, Enemy1Attack, Enemy2Attack, DMGInfo_Pos1, DMGInfo_Pos2);
                eattack.Normalni_Utok_E2(CurrentHP, DMGInfo_Thief, Enemy1, Enemy2, EnemyPositionM1, EnemyPositionM2, CurrentHPEnemy1, CurrentHPEnemy2, MaxHPEnemy1, MaxHPEnemy2, Enemy1Attack, Enemy2Attack, DMGInfo_Pos1, DMGInfo_Pos2);

                if (int.TryParse(CurrentHPEnemy2.Content.ToString(), out int E2HP))
                {
                    if (E2HP < 0)
                    {
                        EnemyCount += 1;
                    }
                    if (E2HP >= 2)
                    {
                        LEVEL();
                    }
                }
            }
            Enemy_Attacks counter = new Enemy_Attacks();
            EnemyCount = counter.EnmCount;

        }

        private void Rychly_utok_Click(object sender, RoutedEventArgs e)
        {
            Attacks attack = new Attacks();
            Enemy_Attacks eattack = new Enemy_Attacks();

            attack.Rychly_Utok(CurrentHPEnemy1, CurrentHPEnemy2, DMGInfo_Pos1, DMGInfo_Pos2, EnemySelectt);

            if (EnemySelectt == 1)
            {
                eattack.Rychly_Utok_E1(CurrentHP, DMGInfo_Thief, Enemy1, Enemy2, EnemyPositionM1, EnemyPositionM2, CurrentHPEnemy1, CurrentHPEnemy2, MaxHPEnemy1, MaxHPEnemy2, Enemy1Attack, Enemy2Attack, DMGInfo_Pos1, DMGInfo_Pos2);
                eattack.Silny_Utok_E1(CurrentHP, DMGInfo_Thief, Enemy1, Enemy2, EnemyPositionM1, EnemyPositionM2, CurrentHPEnemy1, CurrentHPEnemy2, MaxHPEnemy1, MaxHPEnemy2, Enemy1Attack, Enemy2Attack, DMGInfo_Pos1, DMGInfo_Pos2);
                eattack.Normalni_Utok_E1(CurrentHP, DMGInfo_Thief, Enemy1, Enemy2, EnemyPositionM1, EnemyPositionM2, CurrentHPEnemy1, CurrentHPEnemy2, MaxHPEnemy1, MaxHPEnemy2, Enemy1Attack, Enemy2Attack, DMGInfo_Pos1, DMGInfo_Pos2);

                if (int.TryParse(CurrentHPEnemy1.Content.ToString(), out int E1HP))
                {
                    if (E1HP < 0)
                    {
                        EnemyCount += 1;
                    }
                    if (E1HP >= 2)
                    {
                        LEVEL();
                    }
                }
            }
            else
            {
                eattack.Rychly_Utok_E2(CurrentHP, DMGInfo_Thief, Enemy1, Enemy2, EnemyPositionM1, EnemyPositionM2, CurrentHPEnemy1, CurrentHPEnemy2, MaxHPEnemy1, MaxHPEnemy2, Enemy1Attack, Enemy2Attack, DMGInfo_Pos1, DMGInfo_Pos2);
                eattack.Silny_Utok_E2(CurrentHP, DMGInfo_Thief, Enemy1, Enemy2, EnemyPositionM1, EnemyPositionM2, CurrentHPEnemy1, CurrentHPEnemy2, MaxHPEnemy1, MaxHPEnemy2, Enemy1Attack, Enemy2Attack, DMGInfo_Pos1, DMGInfo_Pos2);
                eattack.Normalni_Utok_E2(CurrentHP, DMGInfo_Thief, Enemy1, Enemy2, EnemyPositionM1, EnemyPositionM2, CurrentHPEnemy1, CurrentHPEnemy2, MaxHPEnemy1, MaxHPEnemy2, Enemy1Attack, Enemy2Attack, DMGInfo_Pos1, DMGInfo_Pos2);

                if (int.TryParse(CurrentHPEnemy2.Content.ToString(), out int E2HP))
                {
                    if (E2HP < 0)
                    {
                        EnemyCount += 1;
                    }
                    if (E2HP >= 2)
                    {
                        LEVEL();
                    }
                }
            }
        }

        private void Normalni_utok_Click(object sender, RoutedEventArgs e)
        {
            Attacks attack = new Attacks();
            Enemy_Attacks eattack = new Enemy_Attacks();

            attack.Normalni_Utok(CurrentHPEnemy1, CurrentHPEnemy2, DMGInfo_Pos1, DMGInfo_Pos2, EnemySelectt);

            if (EnemySelectt == 1)
            {
                eattack.Rychly_Utok_E1(CurrentHP, DMGInfo_Thief, Enemy1, Enemy2, EnemyPositionM1, EnemyPositionM2, CurrentHPEnemy1, CurrentHPEnemy2, MaxHPEnemy1, MaxHPEnemy2, Enemy1Attack, Enemy2Attack, DMGInfo_Pos1, DMGInfo_Pos2);
                eattack.Silny_Utok_E1(CurrentHP, DMGInfo_Thief, Enemy1, Enemy2, EnemyPositionM1, EnemyPositionM2, CurrentHPEnemy1, CurrentHPEnemy2, MaxHPEnemy1, MaxHPEnemy2, Enemy1Attack, Enemy2Attack, DMGInfo_Pos1, DMGInfo_Pos2);
                eattack.Normalni_Utok_E1(CurrentHP, DMGInfo_Thief, Enemy1, Enemy2, EnemyPositionM1, EnemyPositionM2, CurrentHPEnemy1, CurrentHPEnemy2, MaxHPEnemy1, MaxHPEnemy2, Enemy1Attack, Enemy2Attack, DMGInfo_Pos1, DMGInfo_Pos2);

                if (int.TryParse(CurrentHPEnemy1.Content.ToString(), out int E1HP))
                {
                    if (E1HP < 0)
                    {
                        EnemyCount += 1;
                    }
                    if (E1HP >= 2)
                    {
                        LEVEL();
                    }
                }
            }
            else
            {
                eattack.Rychly_Utok_E2(CurrentHP, DMGInfo_Thief, Enemy1, Enemy2, EnemyPositionM1, EnemyPositionM2, CurrentHPEnemy1, CurrentHPEnemy2, MaxHPEnemy1, MaxHPEnemy2, Enemy1Attack, Enemy2Attack, DMGInfo_Pos1, DMGInfo_Pos2);
                eattack.Silny_Utok_E2(CurrentHP, DMGInfo_Thief, Enemy1, Enemy2, EnemyPositionM1, EnemyPositionM2, CurrentHPEnemy1, CurrentHPEnemy2, MaxHPEnemy1, MaxHPEnemy2, Enemy1Attack, Enemy2Attack, DMGInfo_Pos1, DMGInfo_Pos2);
                eattack.Normalni_Utok_E2(CurrentHP, DMGInfo_Thief, Enemy1, Enemy2, EnemyPositionM1, EnemyPositionM2, CurrentHPEnemy1, CurrentHPEnemy2, MaxHPEnemy1, MaxHPEnemy2, Enemy1Attack, Enemy2Attack, DMGInfo_Pos1, DMGInfo_Pos2);

                if (int.TryParse(CurrentHPEnemy2.Content.ToString(), out int E2HP))
                {
                    if (E2HP < 0)
                    {
                        EnemyCount += 1;
                    }
                    if (E2HP >= 2)
                    {
                        LEVEL();
                    }
                }
            }
        }






        private void Enemy1Attack_Click(object sender, RoutedEventArgs e)
        {
            EnemySelectt = 1;

            Attacks attack = new Attacks();
            attack.ZobrazitUtoky(Silny_utok, Rychly_utok, Normalni_utok);
        }

        private void Enemy2Attack_Click(object sender, RoutedEventArgs e)
        {
            EnemySelectt = 2;

            Attacks attack = new Attacks();
            attack.ZobrazitUtoky(Silny_utok, Rychly_utok, Normalni_utok);
        }
    }
}
