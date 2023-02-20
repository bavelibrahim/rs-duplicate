using RsDuplicate;
using RsDuplicate.Equipment;
using RsDuplicate.Hero;
using RsDuplicate.Utilities;

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
        public void Check_If_Cannot_EquipWeapon_Mage_Type()
        {
            Warrior warrior = new("Warrior");

            // Staff is one of the types that a Warrior Hero CANNOT equip
            Weapon LightStaff = new("Light", 1, Slots.Weapon, 200, WeaponTypes.Staff);

            // This Function Equips the Weapon
            warrior.EquipWeapon(LightStaff);

            //Check if Exception is thrown which leads to the weapon not being equipable for this Hero.
            Assert.Throws<InvalidWeaponTypeException>(() => {
                if (warrior.Weapontype != LightStaff.WeaponType)
                {
                    // It the Weapontype is not valid for the class it will throw an exception
                    throw new InvalidWeaponTypeException();
                }
            });
        }

        [Fact]
        public void Check_If_Cannot_EquipWeapon_Warrior_RequiredLevel()
        {
            Warrior warrior = new("Warrior");

            // Sword is one of the types that a Warrior Hero can equip
            Weapon sword = new("Light", 3, Slots.Weapon, 200, WeaponTypes.Sword);

            Assert.Throws<InvalidWeaponLevelException>(() => {
                // This Function Equips the Weapon and will throw the exception if the required
                // level is not met
                warrior.EquipWeapon(sword);
            });
        }

        [Fact]
        public void Check_If_Cannot_EquipArmor_Warrior_RequiredLevel()
        {
            Warrior warrior = new("Warrior");

            HeroAttributes attributes = new(2, 1, 0);

            // plate is one of the types that a Warrior Hero can equip
            Armor plate = new("cloth", 9, Slots.Head, attributes, ArmorTypes.Plate);

            Assert.Throws<InvalidArmorLevelException>(() => {
                // This Function Equips the armor and will throw the exception if the required
                // level is not met
                warrior.EquipArmor(plate);
            });
        }

        [Fact]
        public void Check_If_Cannot_EquipArmor_Mage_Type()
        {
            Mage mage = new("Gandalf");

            HeroAttributes attributes = new(2, 1, 0);

            // Plate armor is one of the types that a Mage Hero CANNOT equip
            Armor plate = new("Paladin Platebody", 1, Slots.Body,attributes, ArmorTypes.Plate);

            //Check if Exception is thrown which leads to the weapon not being equipable for this Hero.
            Assert.Throws<InvalidArmorTypeException>(() => {
                // This Function Equips the armor
                mage.EquipArmor(plate);
            });
        }


    }
}
