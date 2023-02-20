﻿using RsDuplicate.Equipment;

namespace RsDuplicate.Hero
{
    public class Ranger : HeroTemplate
    {
        // Start Values for a Level 1 Ranger


        private int Strength = 1;
        private int Dexterity = 7;
        private int Intelligence = 1;

        public WeaponTypes WeaponType;
        public ArmorTypes Armortype;


        public Ranger(string Name) : base(Name) 
        {
            heroAttributes = new(Strength, Dexterity, Intelligence);
            DamageAttribute = 7;

            WeaponType = WeaponTypes.Bow;
            Armortype = ArmorTypes.Leather | ArmorTypes.Mail;

        }
    }
}
