using RsDuplicate.Equipment;
using RsDuplicate.Hero;

namespace RsDuplicate
{
    class program
    {
        static void Main(string[] args)
        {

            Warrior warrior = new("Elian");

            int TotalAttributes = warrior.TotalAttributes();
            Console.WriteLine("TotalAttributes before: " + TotalAttributes);

            HeroAttributes attributes = new(1, 2, 2);

            Armor armorPlate = new("Elians Armor", 1, Slots.Head, attributes, ArmorTypes.Plate);

            warrior.EquipArmor(armorPlate);

            TotalAttributes = warrior.TotalAttributes();
            Console.WriteLine("TotalAttributes After Equipping armor: " + TotalAttributes);

        }
    }
}