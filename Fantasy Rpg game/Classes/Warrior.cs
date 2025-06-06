﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Fantasy_Rpg_game.specialAttacks;
using Fantasy_Rpg_game.weapons;

namespace Fantasy_Rpg_game.Class
{
    internal class Warrior : Character
    {
        // Variables
        private string name;
        private Race race;
        private int health;
        private int rage;
        private int strength;
        private int intellect;
        private int speed;
        private WarriorSpecialAttack specialAttack;
        private Weapon weapon;

        // Getters and Setters
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Health
        {
            get { return health; }
            set { health = 100; }
        }

        public int Rage
        {
            get { return rage; }
            set { rage = value; }
        }

        public int Strength
        {
            get { return strength; }
            set { strength = value; }
        }

        public int Intellect
        {
            get { return intellect; }
            set { intellect = value; }
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }


        // Constructor
        public Warrior(string name, Race race, int health, int rage, int strength,int intellect, int speed, WarriorSpecialAttack specialAttack, Weapon weapon)
        {
            this.name = name;
            this.race = race;
            this.health = health;
            this.rage = rage;
            this.strength = strength;
            this.Intellect = intellect;
            this.speed = speed;
            this.specialAttack = specialAttack;
            this.weapon = weapon;

            ApplyRaceBonus();
        }

        // Race characteristics
        private void ApplyRaceBonus()
        {
            switch (race) 
            {
                case Race.Human:
                    health += 20;
                    break;
                case Race.Elf:
                    if (health <= 20) health += 100;
                    break;
                case Race.Dwarf:
                    strength += 10;
                    Intellect -= 10;
                    speed -= 5;
                    break;
                case Race.Orc:
                    rage += 20;
                    break;
                case Race.Goblin:
                    speed += 10;
                    strength -= 5;
                    break;
            }
        }

        // Special attacks
        public void SpecialAttack(Warrior target)
        {
            switch (specialAttack) {
                case WarriorSpecialAttack.SpinSwing:
                    target.health -= (strength + 10);
                    weapon.Durability -= 10;
                    this.rage -= 5;
                    break;
                case WarriorSpecialAttack.HammerDrop:
                    strength += 15;
                    weapon.Durability -= 15;
                    break;
                case WarriorSpecialAttack.DivineSlash:
                    strength += 20;
                    weapon.Durability -= 20;
                    break;
                case WarriorSpecialAttack.BoneBraker:
                    strength += 20;
                    weapon.Durability -= 20;
                    break;
            }

            Console.WriteLine($"{name} used {specialAttack} on {target.Name}!");
        }


        // Attack function
        public void Attack(Warrior target)
        {
            string target_name = target.Name;
            int target_health = target.Health;
            int self_rage = rage;
            rage += 20;
            int remaining_health = target_health - strength;
            Console.WriteLine($"{name} attaked {target_name}, remaining health is {remaining_health}");
        }

        // String
        public override string ToString()
        {
            return $"Name: {name}\nRace: {race}\nHealth: {health}\nRage: {rage}\nStrength: {strength}\nSpeed: {speed}\nSpecial Attack: {specialAttack} \nWeapon: {weapon.WeaponName}";
        }

    }

    }
