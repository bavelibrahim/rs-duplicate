using RsDuplicate.Equipment;

namespace RsDuplicate.Hero
{
    public class Mage : HeroTemplate
    {
        // Start Values for a Level 1 Mage
        private int Strength = 1;
        private int Dexterity = 1;
        private int Intelligence = 8;
        public WeaponTypes WeaponTypes;
        public ArmorTypes Armortype;

        public Mage(string Name) : base(Name)
        {
            //HeroAttributes is set here and done for each subclass of HeroTemplate
            //damageattribute is set here as the standard value
            heroAttributes = new(Strength, Dexterity, Intelligence);
            DamageAttribute = 8;

            WeaponTypes = WeaponTypes.Staff | WeaponTypes.Wand;

            Armortype = ArmorTypes.Cloth;
        }

    }
}
