using Fantasy_Rpg_game.specialAttacks;
using Fantasy_Rpg_game.weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_Rpg_game.Classes
{
    internal class Sorcerer
    {
        // Variables
        private string name;
        private Race race;
        private int health;
        private int mana;
        private int strenght;
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

        public int Strenght
        {
            get { return strenght; }
            set { strenght = value; }
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public Sorcerer(string name, Race race, int health, int mana, int strenght, int speed, SorcererSpecialAttack specialAttack, Weapon weapon) { 
            this.name = name;
            this.race = race;
            this.health = health;
            this.mana = mana;
            this.strenght = strenght;
            this.speed = speed;
            this.specialAttack = specialAttack;
            this.weapon = weapon;
        }



    }
}
