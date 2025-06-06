﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_Rpg_game.weapons
{
    internal class Weapon
    {
        // Variables
        private string weaponName;
        private WeaponType weaponType;
        private int durability;
        private int weaponSpeed;
        private int physicalDamage;
        private int magicalDamage;
        private WeaponRarity weaponRarity;

        // Getters and Stters
        public string WeaponName
        {
            get { return weaponName; }
            set { weaponName = value; }
        }

        public int Durability
        {
            get { return durability; }
            set { durability = value; }
        }

        public int WeaponSpeed
        {
            get { return weaponSpeed; }
            set { weaponSpeed = value; }
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

        


        // Constructor
        public Weapon(string weaponName, WeaponType weaponType, int durability, int weaponSpeed,int physicalDamage, int magicalDamage, WeaponRarity weaponRarity)
        {
            this.weaponName = weaponName;
            this.weaponType = weaponType;
            this.durability = durability;
            this.weaponSpeed = weaponSpeed;
            this.physicalDamage = physicalDamage;
            this.magicalDamage = magicalDamage;
            this.weaponRarity = weaponRarity;

            WeaponRarityType();
        }

        // ---- Rarity attributes -----
        private void WeaponRarityType()
        {
            switch (weaponRarity)
            {
                case WeaponRarity.Common:
                    durability += 10;
                    break;
                case WeaponRarity.Rare:
                    durability += 10;
                    physicalDamage += 5;
                    magicalDamage += 5;
                    break;
                case WeaponRarity.Epic:
                    durability += 15;
                    physicalDamage += 10;
                    magicalDamage += 10;
                    break;
                case WeaponRarity.Legendary:
                    durability += 100;
                    physicalDamage += 20;
                    magicalDamage += 20;
                    break;
                default: 
                    durability = 0; break;
            }
        }

        // ---- Weapon Type ----
        private void WeaponTypeStats()
        {
            switch (weaponType)
            {
                //// ********** to do... **************
            }
        }

        public override string ToString() {
            return $"Name: {weaponName} \nType: {weaponType} \nDurability: {durability} \nPhysical  Damage: {physicalDamage} \nMagical Damage: {magicalDamage} \nRarity: {weaponRarity}";
        }

    }
}
