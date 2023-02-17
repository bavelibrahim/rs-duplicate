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
        private int Strength { get; set; }
        private int Dexterity { get; set; }
        private int Intelligence { get; set; }

        WeaponTypes Weapontype { get; set; }
        ArmorTypes Armortype { get; set; }

        public Warrior(string Name) : base(Name)
        {
            Strength = 5;
            Dexterity = 2;
            Intelligence = 1;

            Weapontype = WeaponTypes.Sword | WeaponTypes.Axe | WeaponTypes.Hammer;
            Armortype = ArmorTypes.Mail | ArmorTypes.Plate;
        }

    }
}
