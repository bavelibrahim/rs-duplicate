
using RsDuplicate.Equipment;
using RsDuplicate.Hero;
using System;

namespace RsDuplicate
{
    class program
    {
        static void Main(string[] args)
        {

            Mage pavelMage = new Mage("Pavel");

            pavelMage.LevelUp();
            Weapon wand = new Weapon("Wand", 1, Slots.Weapon, 2, WeaponTypes.Wand);

            pavelMage.EquipWeapon(wand);

            Console.WriteLine(pavelMage.Damage());

        }
    }
}