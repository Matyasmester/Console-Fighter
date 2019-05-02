using System;

public class Fighter
{
    public int health;
    public int stamina;
    public string name;
    private int armor;
    public int damage;
    private readonly Random random = new Random();       //creating a new Random every time would make it less random, because it is seeded with the current timestamp.

    public Fighter(int health, int stamina, string name, int armor, int damage)
    {
        stamina = 10;
        this.health = health;
        this.stamina = stamina;
        this.name = name;
        this.armor = armor;
        this.damage = damage;
    }

    public Hit attackLight()
    {
        Hit hit = new Hit(damage / 3 + getRandom(2, 5, 2), "Light jab.");
        return hit;
    }

    public Hit attackMedium()
    {
        Hit hit = new Hit(damage / 2 + getRandom(3, 6, 4), "Medium hit.");
        return hit;
    }

    public Hit attackHard()
    {
        Hit hit = new Hit(damage + getRandom(0, 10, 3), "Heavy punch");
        return hit;
    }

    private int getRandom(int min, int max)
    {
        return random.Next(min, max);
    }

    private int getRandom(int min, int max, int variance)
    {
        int var = random.Next(variance);
        if(random.Next(1) == 0)
        {
            return getRandom(min, max) + var;
        } else
        {
            return getRandom(min, max) - var;
        }
    }

    public int getArmor()
    {
        return armor;
    }

    public void setArmor(int newArmor)
    {
        if (newArmor < 0)
        {
            Console.Write("Armor cannot be less than 0!");
        }
        else
        {
            armor = newArmor;
        }
    }
}