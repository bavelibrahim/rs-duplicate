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
        private int Strength { get; set; }
        private int Dexterity { get; set; }
        private int Intelligence { get; set; }

        WeaponTypes WeaponType { get; set; }
        ArmorTypes Armortype { get; set; }


        public Rogue(string Name) : base(Name)
        {
            Strength = 2;
            Dexterity = 6;
            Intelligence = 1;

            WeaponType = WeaponTypes.Dagger | WeaponTypes.Sword;
            Armortype = ArmorTypes.Leather | ArmorTypes.Mail;

        }
    }
}
