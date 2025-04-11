using Fantasy_Rpg_game.Class;
using Fantasy_Rpg_game.specialAttacks;
using Fantasy_Rpg_game.weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_Rpg_game.Classes
{
    internal class Sorcerer : Character
    {
        // Variables
        private string name;
        private Race race;
        private int health;
        private int mana;
        private int strength;
        private int intellect;
        private int speed;
        private SorcererSpecialAttack specialAttack;
        private Weapon weapon;

        //Getters and setters
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public int Mana
        {
            get { return mana; }
            set { mana = value; }
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

        public Sorcerer(string name, Race race, int health, int mana, int strength,int intellect, int speed, SorcererSpecialAttack specialAttack, Weapon weapon) { 
            this.name = name;
            this.race = race;
            this.health = health;
            this.mana = mana;
            this.strength = strength;
            this.intellect = intellect;
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
                    Intellect -= 10;
                    speed -= 5;
                    break;
                case Race.Orc:
                    mana -= 20;
                    break;
                case Race.Goblin:
                    speed += 10;
                    strength -= 5;
                    break;
            }
        }

        // Special attack

        public void SpecialAttack(Warrior target) { 
            
        }

    }
}
