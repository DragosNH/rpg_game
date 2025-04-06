using System;
using Fantasy_Rpg_game;
using Fantasy_Rpg_game.specialAttacks;

public class Program
{
    public static void Main(string[] args)
    {
        Weapon broadSword = new Weapon("Broad Sword", "Sword", 100, 20, 0, "common");
        Warrior sam = new Warrior("Sam", Race.Human, 100, 0, 50, 50, WarriorSpecialAttack.DivineSlash, broadSword);
        Console.WriteLine(sam.ToString());
    }
}
