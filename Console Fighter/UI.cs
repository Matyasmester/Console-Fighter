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
                case "normal":  //let it fall through to default so we certainly set some difficulty.
                default:
                    enemy = new Fighter(75, 30, "Duck", 1, 20);
                    break;
            }
            EnemyHP.Text = "Enemy HP: " + enemy.health;
        }
        
        private void EasyDiffButton_Click(object sender, EventArgs e)
        {
            initEnemy("easy");
        }

        private void MediumDiffButton_Click(object sender, EventArgs e)
        {
            initEnemy("kurvamindegymitirokide_mertdefaultlesz.");
        }

        private void HardDiffButton_Click(object sender, EventArgs e)
        {
            initEnemy("hard");
        }
        private void LightHitButton_Click(object sender, EventArgs e)
        {
            Hit playerHit = player.attackLight();
            Hit enemyHit = generateEnemyHit(playerHit);
            playRound(playerHit, enemyHit);
        }

        private void MediumHitButton_Click(object sender, EventArgs e)
        {
            Hit playerHit = player.attackMedium();
            Hit enemyHit = generateEnemyHit(playerHit);     //this should not be copypasted. TODO: extract the part that repeats into method.
            playRound(playerHit, enemyHit);
        }

        private void HeavyHitButton_Click(object sender, EventArgs e)
        {
            Hit playerHit = player.attackHard();
            Hit enemyHit = generateEnemyHit(playerHit);
            playRound(playerHit, enemyHit);
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
                writeLineToTextBox( String.Format("\n %s evades the %s of %s.", enemy.name, playerHit.name, player.name));
            } else
            {
                enemy.health -= playerDamage;
                EnemyHP.Text = "Enemy HP: " + enemy.health;
                writeLineToTextBox( String.Format("\n %s successfully hits %s for %d damage with a %s .", player.name, enemy.name, playerDamage, playerHit.name));
            }
            checkWinCondition();

            //----------enemy attacks--------- TODO: extract these into a method because a lot is repeated here.
            int enemyDamage = enemyHit.damage - player.getArmor();
            if(0 > enemyDamage)
            {
                writeLineToTextBox( String.Format("\n %s evades the %s of %s.", player.name, enemyHit.name, enemy.name));
            } else
            {
                player.health -= enemyDamage;
                PlayerHP.Text = "Player HP: " + player.health;
                //TODO: this formatting works, replace the others with it. Or, better, create a method for outputting text like this.
                writeLineToTextBox(enemy.name + " successfully hits " + player.name + "for " + enemyDamage + " damage with a " + enemyHit.name +" .");
            }
            checkLoseCondition();
        }

        private void checkWinCondition()
        {
            if(0 > enemy.health)
            {
                writeLineToTextBox( String.Format("\n Congrats you win lol \n"));
            }
        }

        private void checkLoseCondition()
        {
            if(0 > player.health)
            {
                writeLineToTextBox("\n We fuckin lost \n");    //todo improve this, like disable the buttons,.
            }
        }

        private void writeLineToTextBox(String message)
        {
            StatusTB.AppendText("\n" + message + "\n");
        }

    }
}
