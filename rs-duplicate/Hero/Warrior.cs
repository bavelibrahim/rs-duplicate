using RsDuplicate.Equipment;
using RsDuplicate.Hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RsDuplicate
{
    internal class Warrior : HeroTemplate
    {
        // Start Values for a Level 1 Warrior
        private int Strength = 5;
        private int Dexterity = 2;
        private int Intelligence = 1;

        WeaponTypes Weapontype { get; set; }
        ArmorTypes Armortype { get; set; }

        public Warrior(string Name) : base(Name)
        {
            heroAttributes = new(Strength, Dexterity, Intelligence);

            Weapontype = WeaponTypes.Sword | WeaponTypes.Axe | WeaponTypes.Hammer;
            Armortype = ArmorTypes.Mail | ArmorTypes.Plate;
        }

    }
}
