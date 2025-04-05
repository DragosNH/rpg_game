using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fantasy_Rpg_game;

namespace Fantasy_Rpg_game
{
    internal class Weapon
    {
        private string weaponName;
        private string weaponType;
        private int durability;
        private int physicalDamage;
        private int magicalDamage;
        private string weaponRarity;


        public string WeaponName
        {
            get { return weaponName; }
            set { weaponName = value; }
        }

        public string Weapontype
        {
            get { return weaponType; }
            set { weaponType = value; }
        }

        public int Durability
        {
            get { return durability; }
            set { durability = value; }
        }

        public int PhysicalDamage
        {
            get { return physicalDamage; }
            set { physicalDamage = value; }
        }

        public int MagicalDamage
        {
            get { return magicalDamage; }
            set { magicalDamage = value; }
        }

        public string WeaponRarity
        {
            get { return weaponRarity; }
            set { weaponRarity = value; }
        }



        public Weapon(string weaponName, string weaponType, int durability, int physicalDamage, int magicalDamage, string weaponRarity)
        {
            this.weaponName = weaponName;
            this.weaponType = weaponType;
            this.durability = durability;
            this.physicalDamage = physicalDamage;
            this.magicalDamage = magicalDamage;
            this.weaponRarity = weaponRarity;
        }

    }
}
