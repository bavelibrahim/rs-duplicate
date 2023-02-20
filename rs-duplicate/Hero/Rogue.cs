﻿using RsDuplicate.Equipment;
using RsDuplicate.Hero;

namespace RsDuplicate
{
    public class Rogue : HeroTemplate
    {
        // Start Values for a Level 1 Rogue
        private int Strength = 2;
        private int Dexterity = 6;
        private int Intelligence = 1;

        public WeaponTypes WeaponType;
        public ArmorTypes Armortype;


        public Rogue(string Name) : base(Name)
        {

            heroAttributes = new(Strength, Dexterity, Intelligence);

            WeaponType = WeaponTypes.Dagger | WeaponTypes.Sword;
            Armortype = ArmorTypes.Leather | ArmorTypes.Mail;

        }
    }
}
