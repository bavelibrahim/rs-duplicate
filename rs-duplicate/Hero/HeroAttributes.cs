
namespace RsDuplicate.Hero
{
    internal class HeroAttributes
    {

        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }

        public HeroAttributes(int Strength, int Dexterity, int Intelligence)
        {
            this.Strength = Strength;
            this.Dexterity = Dexterity;
            this.Intelligence = Intelligence;
        }

        public void LevelUp(int Strength, int Dexterity, int Intelligence)
        {
            this.Strength += Strength;
            this.Dexterity += Dexterity;
            this.Intelligence += Intelligence;
        }


    }
}
