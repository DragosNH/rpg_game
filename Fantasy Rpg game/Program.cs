using System;
using Fantasy_Rpg_game;
using Fantasy_Rpg_game.specialAttacks;
using Fantasy_Rpg_game.weapons;

public class Program
{
    public static void Main(string[] args)
    {
        Weapon broadSword = new Weapon("Broad Sword", "Sword", 100, 20, 0, WeaponRarity.Normal);
        Warrior sam = new Warrior("Sam", Race.Human, 100, 0, 50, 50, WarriorSpecialAttack.DivineSlash, broadSword);
        
        Weapon woodSword = new Weapon("Wood Sword", "Sword", 50, 10, 0, WeaponRarity.Normal);
        Warrior novice = new Warrior("novice", Race.Orc, 100, 0, 50, 50, WarriorSpecialAttack.SpinSwing, woodSword);

        Console.WriteLine("---Fight Scene---");
        sam.Attack(novice);
        Console.WriteLine("---Sam's stats---");
        Console.WriteLine(sam);

    }
}
