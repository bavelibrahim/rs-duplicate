using RsDuplicate.Equipment;
using RsDuplicate.Hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace rs_test
{
    public class Hero_Display_Elements
    {
        [Fact]
        public void Hero_Display_TotalAttributes_NoEquipment()
        {

            Mage mage = new("John Doe");

            double totalAttributes = mage.TotalAttributes();

            double expected_Result = 10;

            Assert.Equal(expected_Result, totalAttributes);

        }

        [Fact]
        public void Hero_Display_TotalAttributes_OneEquipment()
        {

            Mage mage = new("John Doe");

            HeroAttributes RobeAttributes = new(0, 1, 5);

            Armor Robe = new("Robe", 1, Slots.Body, RobeAttributes, ArmorTypes.Cloth);

            mage.EquipArmor(Robe);

            int totalAttributes = mage.TotalAttributes();

            int expected_Result = 16;

            Assert.Equal(expected_Result, totalAttributes);

        }

        [Fact]
        public void Hero_Display_TotalAttributes_TwoEquipment()
        {

            Mage mage = new("John Doe");

            HeroAttributes RobeAttributes = new(0, 1, 5);

            Armor Robe = new("Robe", 1, Slots.Body, RobeAttributes, ArmorTypes.Cloth);
            Armor Legs = new("Legs", 1, Slots.Legs, RobeAttributes, ArmorTypes.Cloth);

            mage.EquipArmor(Robe);
            mage.EquipArmor(Legs);

            int totalAttributes = mage.TotalAttributes();

            int expected_Result = 22;

            Assert.Equal(expected_Result, totalAttributes);

        }

        [Fact]
        public void Hero_Display_TotalAttributes_ReplacedEquipment()
        {

            Mage mage = new("John Doe");

            HeroAttributes RobeAttributes = new(0, 1, 5);
            HeroAttributes HolyRobeAttributes = new(0, 1, 11);

            Armor Robe = new("Robe", 1, Slots.Body, RobeAttributes, ArmorTypes.Cloth);
            Armor HolyRobe = new("HolyRobe", 1, Slots.Body, HolyRobeAttributes, ArmorTypes.Cloth);

            mage.EquipArmor(Robe);
            mage.EquipArmor(HolyRobe);

            int totalAttributes = mage.TotalAttributes();

            int expected_Result = 22;

            Assert.Equal(expected_Result, totalAttributes);

        }

        [Fact]
        public void Hero_Display_DamageAttribute_NoWeapon()
        {

            Mage mage = new("John Doe");

            // Standard damage of a Mage is = Its Intelligence
            // New mage Hero starts with 8 intelligence
            int expected_Result = 8;

            Assert.Equal(expected_Result, mage.DamageAttribute);

        }

        [Fact]
        public void Hero_Display_DamageAttribute_WithWeaponEquipped()
        {

            Mage mage = new("John Doe");

            Weapon FireStaff = new("FireStaff", 1, Slots.Weapon, 20, WeaponTypes.Staff);

            mage.EquipWeapon(FireStaff);
            double damageValue = mage.Damage();

            // This is the expected Result after calculating damage with the new Weapon
            double expectedResult = 21.600000000000001;

            Assert.Equal(expectedResult, damageValue);

        }

        [Fact]
        public void Hero_Display_DamageAttribute_WeaponReplaced()
        {

            Mage mage = new("John Doe");

            Weapon FireStaff = new("FireStaff", 1, Slots.Weapon, 20, WeaponTypes.Staff);
            Weapon HolyStaff = new("HolyStaff", 1, Slots.Weapon, 300, WeaponTypes.Staff);

            mage.EquipWeapon(FireStaff);
            mage.EquipWeapon(HolyStaff);

            double damageValue = mage.Damage();

            // This is the expected Result after calculating damage with the new Weapon
            double expectedResult = 324;

            Assert.Equal(expectedResult, damageValue);

        }

        [Fact]
        public void Hero_Display_Damage_WithArmorAndWeapon()
        {

            Mage mage = new("John Doe");

            HeroAttributes HolyClothAttributes = new(2, 3, 24);

            Weapon HolyStaff = new("HolyStaff", 1, Slots.Weapon, 300, WeaponTypes.Staff);
            Armor HolyCloth = new("HolyCloth", 1, Slots.Body, HolyClothAttributes, ArmorTypes.Cloth);

            mage.EquipWeapon(HolyStaff);
            mage.EquipArmor(HolyCloth);
            mage.TotalAttributes();

            double damageValue = mage.Damage();

            // This is the expected Result after calculating damage with the new Weapon and new Armor equipped
            double expectedResult = 396;

            Assert.Equal(expectedResult, damageValue);

        }

        [Fact]
        public void Hero_Display_AllCorrectly()
        {

            Mage mage = new("John Doe");

            HeroAttributes HolyClothAttributes = new(2, 3, 24);

            Weapon HolyStaff = new("HolyStaff", 1, Slots.Weapon, 300, WeaponTypes.Staff);
            Armor HolyClothBody = new("HolyClothBody", 1, Slots.Body, HolyClothAttributes, ArmorTypes.Cloth);
            Armor HolyClothLegs = new("HolyClothLegs", 1, Slots.Legs, HolyClothAttributes, ArmorTypes.Cloth);
            Armor HolyClothHood = new("HolyClothHood", 1, Slots.Head, HolyClothAttributes, ArmorTypes.Cloth);

            mage.EquipWeapon(HolyStaff);
            mage.EquipArmor(HolyClothBody);
            mage.EquipArmor(HolyClothLegs);
            mage.EquipArmor(HolyClothHood);
            mage.TotalAttributes();

            StringBuilder builder = new StringBuilder();

            builder.AppendLine("Hero Name: " + mage.Name);
            builder.AppendLine("Hero Class: " + mage.GetType().ToString());
            builder.AppendLine("Hero Level: " + mage.Level.ToString());
            builder.AppendLine("Total Strength: " + mage.heroAttributes.Strength.ToString());
            builder.AppendLine("Total Dexterity: " + mage.heroAttributes.Dexterity.ToString());
            builder.AppendLine("Total Intelligence: " + mage.heroAttributes.Intelligence.ToString());
            builder.AppendLine("Hero Damage: " + mage.Damage().ToString());

            Assert.Equivalent(builder, mage.Display());

        }

    }
}
