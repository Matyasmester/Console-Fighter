using System;

public class Fighter
{
    public int health;
    public string name;
    private int armor;
    public int damage;

    public Fighter(int health, string name, int armor, int damage)
    {
        this.health = health;
        this.name = name;
        this.armor = armor;
        this.damage = damage;
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