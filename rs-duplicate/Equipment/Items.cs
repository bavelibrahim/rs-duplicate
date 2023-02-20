
namespace RsDuplicate.Equipment
{
    public enum Slots
    {
        Weapon,
        Head,
        Body,
        Legs
    }

    internal class Items
    {

        private string Name;
        private int RequiredLevel;
        private Slots Slots { get; set; }

        public Slots slots { get => Slots; set => Slots = value; }
        public string name { get => Name; set => Name = value; }
        public int requiredLevel { get => RequiredLevel; set => RequiredLevel = value; }

        public Items(string name, int requiredLevel, Slots slot) { 
            Name = name;
            RequiredLevel = requiredLevel;
            Slots = slot;
        }



    }
}
