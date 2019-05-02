using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Console_Fighter
{
    public partial class UI : Form
    {
        Fighter player;
        Fighter enemy;
        readonly Random rnd = new Random();
        public UI()
        {
            InitializeComponent();
            initFighters();
        }

        private void initFighters()
        {
            initPlayer();
            initEnemy("normal");
        }

        private void initPlayer()
        {
            player = new Fighter(100, 30, "Jorge", 5, 20);
            PlayerHP.Text = "Player HP: " + player.health;
            StaminaLabel.Text = "Stamina: " + player.stamina;
        }
        private void buttonStatus(string type, string status)
        {
            if (type == "diff")
            {
                if (status == "disable")
                {
                    EasyDiffButton.Enabled = false;
                    MediumDiffButton.Enabled = false;
                    HardDiffButton.Enabled = false;
                }
                else if (status == "enable")
                {
                    EasyDiffButton.Enabled = true;
                    MediumDiffButton.Enabled = true;
                    HardDiffButton.Enabled = true;
                }
            }
            else if (type == "hit")
            {
                if (status == "disable")
                {
                    LightHitButton.Enabled = false;
                    MediumHitButton.Enabled = false;
                    HeavyHitButton.Enabled = false;
                }
                else if (status == "enable")
                {
                    LightHitButton.Enabled = true;
                    MediumHitButton.Enabled = true;
                    HeavyHitButton.Enabled = true;
                }
            }
        }

        private void initEnemy(string difficulty)
        {
            switch(difficulty)
            {
                case "easy":
                    enemy = new Fighter(50, 20, "Ben", 0, 10);
                    break;
                case "hard":
                    enemy = new Fighter(100, 100, "Kenny", 2, 30);
                    break;
                case "normal":  
                default:
                    enemy = new Fighter(75, 30, "Duck", 1, 20);
                    break;
            }
            EnemyHP.Text = "Enemy HP: " + enemy.health;
        }
        
        private void EasyDiffButton_Click(object sender, EventArgs e)
        {
            initEnemy("easy");
            buttonStatus("diff", "disable");
        }

        private void MediumDiffButton_Click(object sender, EventArgs e) 
        {
            initEnemy("normal");
            buttonStatus("diff", "disable");
        }

        private void HardDiffButton_Click(object sender, EventArgs e)
        {
            initEnemy("hard");
            buttonStatus("diff", "disable");
        }
        private void Attack(string atkType)
        {
            Hit playerHit;
            if (atkType == "light")
            {
                playerHit = player.attackLight();
                player.stamina -= 1;
            }
            else if (atkType == "medium")
            {
                playerHit = player.attackMedium();
                player.stamina -= 1;
            }
            else
            {
                if (player.stamina <= 3)
                {
                    writeLineToTextBox(player.name + " is too tired to do a heavy punch, he does a light jab instead.");
                    playerHit = player.attackLight();
                }
                else
                {
                    playerHit = player.attackHard();
                    player.stamina -= 3;
                }
            }
            StaminaLabel.Text = "Stamina: " + player.stamina;
            Hit enemyHit = generateEnemyHit(playerHit);
            playRound(playerHit, enemyHit);
        }
        private void LightHitButton_Click(object sender, EventArgs e)
        {
            Attack("light");
        }

        private void MediumHitButton_Click(object sender, EventArgs e)
        {
            Attack("medium");                                                   
        }

        private void HeavyHitButton_Click(object sender, EventArgs e)
        {
            Attack("hard");
        }

        
        private Hit generateEnemyHit(Hit playerHit)
        {
            //world's dumbest AI, just creates a hit similar to what the player did.
            Hit enemyHit;
            if(5 > playerHit.damage)
            {
                enemyHit = enemy.attackLight();
            } else if (12 > playerHit.damage)
            {
                enemyHit = enemy.attackMedium();
            } else
            {
                enemyHit = enemy.attackHard();
            }
            return enemyHit;
        }

        private void playRound(Hit playerHit, Hit enemyHit)
        {
            //--------player attacks------------
            int playerDamage = playerHit.damage - enemy.getArmor();
            if (0 > playerDamage)
            {
                writeLineToTextBox(player.name + " evades " + enemy.name + "'s " + enemyHit.name + ".");
            } else
            {
                enemy.health -= playerDamage;
                EnemyHP.Text = "Enemy HP: " + enemy.health;
                writeLineToTextBox(player.name + " successfully hits " + enemy.name + " for " + playerDamage + " damage with a " + playerHit.name + " .");
            }
            checkWinCondition();

            //----------enemy attacks--------- TODO: extract these into a method because a lot is repeated here.
            int enemyDamage = enemyHit.damage - player.getArmor();
            if(0 > enemyDamage)
            {
                writeLineToTextBox(enemy.name + " evades " + player.name + "'s " + playerHit.name + ".");
            } else
            {
                player.health -= enemyDamage;
                PlayerHP.Text = "Player HP: " + player.health;
                writeLineToTextBox(enemy.name + " successfully hits " + player.name + " for " + enemyDamage + " damage with a " + enemyHit.name +" .");
            }
            checkLoseCondition();
        }

        private void checkWinCondition()
        {
            if(0 > enemy.health)
            {
                writeLineToTextBox( String.Format("\n Congrats you win lol \n"));
                buttonStatus("diff", "disable");
                buttonStatus("hit", "disable");
            }
        }

        private void checkLoseCondition()
        {
            if(player.health <= 0)
            {
                writeLineToTextBox("\n We fuckin lost \n");
                buttonStatus("diff", "disable");
                buttonStatus("hit", "disable");
            }
        }

        private void writeLineToTextBox(String message)
        {
            StatusTB.AppendText("\n" + message + "\n");
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            buttonStatus("diff", "enable");
            buttonStatus("hit", "enable");
            initEnemy("easy");
            initPlayer();
            StatusTB.Clear();
        }
    }
}
