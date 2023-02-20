
using RsDuplicate.Equipment;
using RsDuplicate.Hero;

namespace RsDuplicate
{
    class program
    {
        static void Main(string[] args)
        {
            Mage pavelMage = new("Pavel");

            Weapon StaffOfLight = new("Light Staff", 1, Slots.Weapon, 1, WeaponTypes.Staff);
            HeroAttributes BodyOfProAttributes = new HeroAttributes(1, 1, 3);
            Armor BodyOfProtection = new Armor("BodyPro", 1, Slots.Body, BodyOfProAttributes, ArmorTypes.Cloth);

            pavelMage.EquipWeapon(StaffOfLight);
            pavelMage.EquipArmor(BodyOfProtection);

            pavelMage.Display();
        }
    }
}