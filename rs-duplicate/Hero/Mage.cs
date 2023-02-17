using RsDuplicate.Equipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RsDuplicate.Hero
{
    internal class Mage : HeroTemplate
    {
        // Start Values for a Level 1 Mage
        public int Strength;
        public int Dexterity;
        public int Intelligence;
        public WeaponTypes WeaponTypes { get; set; }
        private WeaponTypes weapontype { get; set; }
        public ArmorTypes Armortype { get; set; }

        public Mage(string Name) : base(Name)
        {
            Strength = 1;
            Dexterity = 1;
            Intelligence = 8;

            WeaponTypes = WeaponTypes.Staff | WeaponTypes.Wand;
            Armortype = ArmorTypes.Cloth;
        }

    }
}
