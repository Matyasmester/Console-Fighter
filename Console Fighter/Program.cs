using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Fighter
{
    class Program
    {

        static void Main()
        {
            string diff;
            Random rnd = new Random();

            Fighter player;
            Fighter enemy;

            Console.Write("Difficulty: ");
            Console.WriteLine("1) Easy,  2) Medium,  3) Hard.");
            diff = Console.ReadLine();
            if(diff == "1")
            {
                enemy = new Fighter(50, "Ben", 0, 10);
                player = new Fighter(100, "Jorge", 5, 20);
            }
            else if(diff == "2")
            {
                enemy = new Fighter(75, "Duck", 3, 20);
                player = new Fighter(80, "Zopad", 2, 20);
            }
            else if(diff == "3")
            {
                enemy = new Fighter(100, "Kenny", 10, 30);
                player = new Fighter(50, "A.J.", 0, 10);
            } else
            {
                Console.WriteLine("Write a difficulty, fam.");
                Console.Read();
                return;
            }

            Hit lightHit = new Hit(rnd.Next(1, 7), "Light jab.");
            Hit mediumHit = new Hit(rnd.Next(3, 8), "Medium hit.");
            Hit heavyHit = new Hit(rnd.Next(6, player.damage), "Heavy punch.");
            Hit enemyHeavyHit;

            Console.WriteLine("Difficulty: " + diff);
            Console.WriteLine("Player stats: Health: " + player.health + "| Name: " + player.name + "| Armor: " + player.getArmor() + "| Damage: " + player.damage);
            Console.WriteLine("Enemy stats: Health: " + enemy.health + "| Name: " + enemy.name + "| Armor: " + enemy.getArmor() + "| Damage: " + enemy.damage);
            
            while(player.health > 0)
            {
                void PlayerAtk()
                {
                    Console.Write("How do you attack? ");
                    Console.WriteLine("1) Light jab,  2) Medium blow,  3) Heavy punch.");
                    string atk = Console.ReadLine();
                    if (atk == "1")
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
                    else if (atk == "2")
                    {
                        if (mediumHit.damage - enemy.getArmor() <= 0)
                        {
                            Console.WriteLine("Player misses a " + mediumHit.name);
                        }
                        else
                        {
                            player.health -= (mediumHit.damage - enemy.getArmor());
                            Console.WriteLine("Player hits with a " + mediumHit.name);
                        }
                    }
                    else if (atk == "3")
                    {
                        enemy.health -= heavyHit.damage;
                        Console.WriteLine("Player hits with a " + heavyHit.name);
                    }
                    if (enemy.health <= 0)
                    {
                        Console.WriteLine("Player wins the match!");
                        Console.Read();
                        return;
                    }
                    Console.WriteLine("Remaining enemy health: " + enemy.health);
                }
                void EnemyAtk()
                {
                    Random rand = new Random();
                    if (rand.Next(1, 4) == 1)
                    {
                        if (lightHit.damage - player.getArmor() <= 0)
                        {
                            Console.WriteLine("Enemy misses a " + lightHit.name);
                        }
                        else
                        {
                            player.health -= (lightHit.damage - player.getArmor());
                            Console.WriteLine("Enemy hits with a " + lightHit.name);
                        }
                    }
                    else if (rand.Next(1, 4) == 2)
                    {
                        if (mediumHit.damage - player.getArmor() <= 0)
                        {
                            Console.WriteLine("Enemy misses a " + mediumHit.name);
                        }
                        else
                        {
                            player.health -= (mediumHit.damage - player.getArmor());
                            Console.WriteLine("Enemy hits with a " + mediumHit.name);
                        }
                    }
                    else
                    {
                        enemyHeavyHit = new Hit(rnd.Next(6, enemy.damage), "Heavy hit");
                        player.health -= enemyHeavyHit.damage;
                        Console.WriteLine("Enemy hits with a " + heavyHit.name);
                    }
                    if (player.health <= 0)
                    {
                        Console.WriteLine("Enemy wins the match!");
                        Console.Read();
                        return;
                    }
                    Console.WriteLine("Remaining player health: " + player.health);
                }
                PlayerAtk();
                EnemyAtk();
            }
        }
    }
}
