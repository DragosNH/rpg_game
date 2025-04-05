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
        private int health;
        private int rage;
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

        public Warrior(string name, int health, int rage, int speed, string specialAttack, Weapon weapon)
        {
            this.name = name;
            this.health = health;
            this.rage = rage;
            this.speed = speed;
            this.specialAttack = specialAttack;
            this.weapon = weapon;
        }

        public override string ToString()
        {
            return $"Name: {name}\nHealth: {health}\nRage: {rage}\nSpeed: {speed}\nSpecial Attack: {specialAttack}\nWeapon: {weapon.WeaponName}";
        }

    }
}
