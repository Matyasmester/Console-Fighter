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
        public UI()
        {
            InitializeComponent();
        }
        Fighter player;
        Fighter enemy;
        Random rnd = new Random();
        Hit lightHit = new Hit(rnd.Next(1, 7), "Light jab.");
        Hit mediumHit = new Hit(rnd.Next(3, 8), "Medium hit.");
        Hit heavyHit = new Hit(rnd.Next(6, player.damage), "Heavy punch.");
        Hit enemyHeavyHit;
        public void Button1_Click(object sender, EventArgs e)
        {
            if (lightHit.damage - enemy.getArmor() <= 0)
            {
                Console.WriteLine("Player misses a " + lightHit.name);
            }
            else
            {
                player.health -= (lightHit.damage - enemy.getArmor());
                Console.WriteLine("Player hits with a " + lightHit.name);
            }
        }
        private void EasyDiffButton_Click(object sender, EventArgs e)
        {
            enemy = new Fighter(50, "Ben", 0, 10);
            player = new Fighter(100, "Jorge", 5, 20);
        }

        private void MediumDiffButton_Click(object sender, EventArgs e)
        {
            enemy = new Fighter(75, "Duck", 3, 20);
            player = new Fighter(80, "Zopad", 2, 20);
        }

        private void HardDiffButton_Click(object sender, EventArgs e)
        {
            enemy = new Fighter(100, "Kenny", 10, 30);
            player = new Fighter(50, "A.J.", 0, 10);
        }
    }
}
