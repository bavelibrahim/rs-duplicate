using RsDuplicate.Equipment;
using RsDuplicate.Hero;

namespace RsDuplicate
{
    public class Rogue : HeroTemplate
    {
        // Start Values for a Level 1 Rogue
        private int Strength = 2;
        private int Dexterity = 6;
        private int Intelligence = 1;

        public WeaponTypes WeaponType;
        public ArmorTypes Armortype;


        public Rogue(string Name) : base(Name)
        {
            //HeroAttributes is set here and done for each subclass of HeroTemplate
            //damageattribute is set here as the standard value
            heroAttributes = new(Strength, Dexterity, Intelligence);
            DamageAttribute = 6;


            WeaponType = WeaponTypes.Dagger | WeaponTypes.Sword;
            Armortype = ArmorTypes.Leather | ArmorTypes.Mail;

        }
    }
}
