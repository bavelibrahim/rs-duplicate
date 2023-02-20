using RsDuplicate.Equipment;
using RsDuplicate.Hero;

namespace RsDuplicate
{
    class program
    {
        static void Main(string[] args)
        {

            Mage mage = new("Elian");

            HeroAttributes attributes = new(1, 2, 0);

            Armor armorPlate = new("Elians Armor", 1, Slots.Head, attributes, ArmorTypes.Plate);

            mage.EquipArmor(armorPlate);




        }
    }
}