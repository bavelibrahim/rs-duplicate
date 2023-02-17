using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RsDuplicate.Equipment
{

    [Flags]
    enum ArmorTypes
    {
        Cloth = 0,
        Leather = 1,
        Mail = 2,
        Plate = 4
    }

    internal class Armor : Items
    {

        // These are the ArmorTypes attributes for the ArmorTypes

        private ArmorTypes ArmorTypes;

        public HeroAttributes armorAttributes;
        public ArmorTypes armorTypes { get => ArmorTypes; set => ArmorTypes = value; }

        public Armor(string name, int requiredLevel, Slots slots, HeroAttributes armorAttribute, ArmorTypes armorTypes) : base(name, requiredLevel, slots)
        {
            armorAttributes.Strength = armorAttribute.Strength;
            armorAttributes.Dexterity = armorAttribute.Dexterity;
            armorAttributes.Intelligence = armorAttribute.Intelligence;

            ArmorTypes = armorTypes;
        }


    }
}
