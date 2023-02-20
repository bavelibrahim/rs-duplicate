using RsDuplicate.Equipment;

namespace RsDuplicate.Hero
{
    public class Ranger : HeroTemplate
    {
        // Start Values for a Level 1 Ranger


        private int Strength = 1;
        private int Dexterity = 7;
        private int Intelligence = 1;

        WeaponTypes WeaponType { get; set; }
        ArmorTypes Armortype { get; set; }


        public Ranger(string Name) : base(Name) 
        {
            heroAttributes = new(Strength, Dexterity, Intelligence);

            WeaponType = WeaponTypes.Bow;
            Armortype = ArmorTypes.Leather | ArmorTypes.Mail;

        }
    }
}
