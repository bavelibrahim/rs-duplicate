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

        private HeroAttributes ArmorAttributes;
        private ArmorTypes ArmorTypes;

        public HeroAttributes armorAttributes { get => ArmorAttributes;  set => ArmorAttributes = value; }
        public ArmorTypes armorTypes { get => ArmorTypes; set => ArmorTypes = value; }

        public Armor(string name, int requiredLevel, Slots slots, HeroAttributes armorAttribute, ArmorTypes armorTypes) : base(name, requiredLevel, slots)
        {
            ArmorAttributes.Strength = armorAttribute.Strength;
            ArmorAttributes.Dexterity = armorAttribute.Dexterity;
            ArmorAttributes.Intelligence = armorAttribute.Intelligence;

            ArmorTypes = armorTypes;
        }


    }
}
