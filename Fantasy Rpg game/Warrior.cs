using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fantasy_Rpg_game;

namespace Fantasy_Rpg_game
{
    internal class Warrior
    {
        private string name;
        private Race race;
        private int health;
        private int rage;
        private int strength;
        private int speed;
        private string specialAttack;
        private Weapon weapon;

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

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public string SpecialAttack
        {
            get { return specialAttack; }
            set { specialAttack = value; }
        }

        public Warrior(string name, Race race, int health, int rage, int strength, int speed, string specialAttack, Weapon weapon)
        {
            this.name = name;
            this.race = race;
            this.health = health;
            this.rage = rage;
            this.strength = strength;
            this.speed = speed;
            this.specialAttack = specialAttack;
            this.weapon = weapon;

            ApplyRaceBonus();
        }

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

        public override string ToString()
        {
            return $"Name: {name}\nRace: {race}\nHealth: {health}\nRage: {rage}\nStrength: {strength}\nSpeed: {speed}\nSpecial Attack: {specialAttack}\nWeapon: {weapon.WeaponName}";
        }

    }

    }
