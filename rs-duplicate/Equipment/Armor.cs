using RsDuplicate.Hero;

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

        public HeroAttributes armorAttribute;
        private ArmorTypes armorType;


        public ArmorTypes ArmorTypes { 
            get => armorType; 
            set => armorType = value; 
        }

        public Armor(string name, int requiredLevel, Slots slots, HeroAttributes attributes, ArmorTypes armorTypes) : base(name, requiredLevel, slots)
        {
            armorAttribute = new(attributes.Strength, attributes.Dexterity, attributes.Intelligence);
            armorType = armorTypes;
        }


    }
}
