using System;
using Fantasy_Rpg_game;

public class Program
{
    public static void Main(string[] args)
    {
        Weapon broadSword = new Weapon("Broad Sword", "Sword", 100, 20, 0, "common");
        Warrior sam = new Warrior("Sam", 100, 0, 50, "Hammer strike", broadSword);
        Console.WriteLine(sam.ToString());
    }
}
