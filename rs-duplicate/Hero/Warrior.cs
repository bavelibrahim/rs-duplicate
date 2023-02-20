using RsDuplicate.Equipment;
using RsDuplicate.Hero;

namespace RsDuplicate
{
    public class Warrior : HeroTemplate
    {
        // Start Values for a Level 1 Warrior
        private int Strength = 5;
        private int Dexterity = 2;
        private int Intelligence = 1;

        public WeaponTypes Weapontype;
        public ArmorTypes Armortype;

        public Warrior(string Name) : base(Name)
        {
            //HeroAttributes is set here and done for each subclass of HeroTemplate
            //damageattribute is set here as the standard value
            heroAttributes = new(Strength, Dexterity, Intelligence);
            DamageAttribute = 5;

            Weapontype = WeaponTypes.Sword | WeaponTypes.Axe | WeaponTypes.Hammer;
            Armortype = ArmorTypes.Mail | ArmorTypes.Plate;
        }

    }
}
