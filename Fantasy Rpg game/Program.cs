using System;
using Fantasy_Rpg_game;
using Fantasy_Rpg_game.Class;
using Fantasy_Rpg_game.specialAttacks;
using Fantasy_Rpg_game.weapons;

public class Program
{
    public static void Main(string[] args)
    {
        Weapon broadSword = new Weapon("Broad Sword", WeaponType.Sword, 100, 20, 20, 0, WeaponRarity.Normal);
        Warrior sam = new Warrior("Sam", Race.Human, 100, 0, 50, 50, WarriorSpecialAttack.SpinSwing, broadSword);
        
        Weapon woodSword = new Weapon("Wood Sword", WeaponType.Sword, 50, 20, 10, 0, WeaponRarity.Normal);
        Warrior novice = new Warrior("novice", Race.Orc, 100, 0, 50, 50, WarriorSpecialAttack.SpinSwing, woodSword);

        Console.WriteLine("---Fight Scene---");
        sam.Attack(novice);
        Console.WriteLine("---Sam's stats---");
        Console.WriteLine(sam);

        sam.SpecialAttack(novice);
        Console.WriteLine("---Sam's rage---");
        Console.WriteLine(sam.Rage);


    }
}
