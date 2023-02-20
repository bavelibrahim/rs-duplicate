using RsDuplicate.Equipment;
using RsDuplicate.Hero;

namespace rs_test
{
    public class Check_Equip_WeaponAndArmor
    {

        [Fact]
        public void Check_If_Can_EquipWeapon_Mage()
        {
            Mage mage = new("Gandalf");

            // Staff is one of the types that a Mage Hero can equip.
            Weapon LightStaff = new("Light", 1, Slots.Weapon, 200, WeaponTypes.Staff);
            
            // We Check if the Hero has the weapon by wielding the Staff and then checking the 
            // equipment slot for the Weapon on the Hero. 

            // This Function Equips the Weapon
            mage.EquipWeapon(LightStaff);

            // This returns True if there is a weapon in the Weapon slot in the Equipment Dictionary List 
            bool isWeaponEquipped = mage.Equipment.TryGetValue(Slots.Weapon, out Items? value);

            //Check if Weapon is Equipped
            Assert.Equivalent(isWeaponEquipped, true);
        }

        [Fact]
        public void Check_If_Cannot_EquipWeapon_Mage()
        {
            Mage mage = new("Gandalf");

            // Staff is one of the types that a Mage Hero can equip.
            Weapon LightStaff = new("Light", 1, Slots.Weapon, 200, WeaponTypes.Staff);

            // We Check if the Hero has the weapon by wielding the Staff and then checking the 
            // equipment slot for the Weapon on the Hero. 

            // This Function Equips the Weapon
            mage.EquipWeapon(LightStaff);

            // This returns True if there is a weapon in the Weapon slot in the Equipment Dictionary List 
            bool isWeaponEquipped = mage.Equipment.TryGetValue(Slots.Weapon, out Items? value);

            //Check if Weapon is Equipped
            Assert.Equivalent(isWeaponEquipped, true);
        }


    }
}
