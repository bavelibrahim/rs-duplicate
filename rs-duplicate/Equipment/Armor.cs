using RsDuplicate.Hero;

namespace RsDuplicate.Equipment
{

    [Flags]
    public enum ArmorTypes
    {
        Cloth = 0,
        Leather = 1,
        Mail = 2,
        Plate = 4
    }

    public class Armor : Items
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
            //Armorattribute is of type HeroAttribute and can be used throughout the code
            //Armortype is when an armor is created
            armorAttribute = new(attributes.Strength, attributes.Dexterity, attributes.Intelligence);
            armorType = armorTypes;
        }


    }
}
