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
        public int Strength = 1;
        public int Dexterity = 1;
        public int Intelligence = 8;
        public WeaponTypes WeaponTypes { get; set; }
        public ArmorTypes Armortype { get; set; }

        public Mage(string Name) : base(Name)
        {
            heroAttributes = new(Strength, Dexterity, Intelligence);

            WeaponTypes = WeaponTypes.Staff | WeaponTypes.Wand;

            Armortype = ArmorTypes.Cloth;
        }

    }
}
