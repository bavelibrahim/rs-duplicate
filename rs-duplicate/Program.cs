
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

            Weapon wand = new Weapon("Wand", 1, Slots.Weapon, 1, WeaponTypes.Wand);

            pavelMage.EquipWeapon(wand);

            Console.WriteLine(pavelMage.Damage());

        }
    }
}