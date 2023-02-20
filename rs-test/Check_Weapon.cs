using RsDuplicate.Equipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rs_test
{
    public class Check_Weapon
    {

        [Fact]
        public void Weapon_Name()
        {
            Weapon weapon = new("Guts GreatSword", 20, Slots.Weapon, 300, WeaponTypes.Sword);

            string Weapon_Name = "Guts GreatSword";
            Assert.Equal(weapon.name, Weapon_Name);
        }

        [Fact]
        public void Weapon_RequiredLevel()
        {
            Weapon weapon = new("Guts GreatSword", 20, Slots.Weapon, 300, WeaponTypes.Sword);

            int requiredLevel = 20;
            Assert.Equal(weapon.requiredLevel, requiredLevel);
        }

        [Fact]
        public void Weapon_Slot()
        {
            Weapon weapon = new("Guts GreatSword", 20, Slots.Weapon, 300, WeaponTypes.Sword);

            Slots weaponSlot = Slots.Weapon;
            Assert.Equivalent(weapon.slots, weaponSlot);
        }

        [Fact]
        public void Weapon_WeaponType()
        {
            Weapon weapon = new("Guts GreatSword", 20, Slots.Weapon, 300, WeaponTypes.Sword);

            WeaponTypes weaponType = WeaponTypes.Sword;
            Assert.Equivalent(weapon.WeaponType, weaponType);
        }

    }
}
