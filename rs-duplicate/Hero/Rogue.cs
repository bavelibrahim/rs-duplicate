using RsDuplicate.Equipment;
using RsDuplicate.Hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RsDuplicate
{
    internal class Rogue : HeroTemplate
    {
        // Start Values for a Level 1 Rogue
        private int Strength = 2;
        private int Dexterity = 6;
        private int Intelligence = 1;

        WeaponTypes WeaponType { get; set; }
        ArmorTypes Armortype { get; set; }


        public Rogue(string Name) : base(Name)
        {

            heroAttributes = new(Strength, Dexterity, Intelligence);

            WeaponType = WeaponTypes.Dagger | WeaponTypes.Sword;
            Armortype = ArmorTypes.Leather | ArmorTypes.Mail;

        }
    }
}
