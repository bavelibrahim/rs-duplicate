using RsDuplicate.Equipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RsDuplicate.Hero
{
    internal class Ranger : HeroTemplate
    {
        // Start Values for a Level 1 Ranger


        private int Strength = 1;
        private int Dexterity = 7;
        private int Intelligence = 1;

        WeaponTypes WeaponType { get; set; }
        ArmorTypes Armortype { get; set; }


        public Ranger(string Name) : base(Name) 
        {
            heroAttributes = new(Strength, Dexterity, Intelligence);

            WeaponType = WeaponTypes.Bow;
            Armortype = ArmorTypes.Leather | ArmorTypes.Mail;

        }
    }
}
