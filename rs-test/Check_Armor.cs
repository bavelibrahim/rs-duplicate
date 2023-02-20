using RsDuplicate.Equipment;
using RsDuplicate.Hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rs_test
{
    public class Check_Armor
    {
        [Fact]
        public void Armor_CheckName()
        {
            HeroAttributes attributes = new HeroAttributes(1,2,0);
            Armor armor = new("Armor", 20, Slots.Body, attributes, ArmorTypes.Plate);

            string armorName = "Armor";
            Assert.Equal(armor.name, armorName);
        }

        [Fact]
        public void Armor_CheckRequiredLevel()
        {
            HeroAttributes attributes = new HeroAttributes(1, 2, 0);
            Armor armor = new("Armor", 20, Slots.Body, attributes, ArmorTypes.Plate);

            int requiredLevel = 20;
            Assert.Equal(armor.requiredLevel, requiredLevel);
        }

        [Fact]
        public void Armor_CheckCorrectSlot_Head()
        {
            HeroAttributes attributes = new HeroAttributes(1, 2, 0);
            Armor armor = new("Mithril Full Helmet", 20, Slots.Head, attributes, ArmorTypes.Plate);

            Slots slot = Slots.Head;
            
            Assert.Equal(armor.slots, slot);
        }

        [Fact]
        public void Armor_CheckCorrectSlot_Body()
        {
            HeroAttributes attributes = new HeroAttributes(1, 2, 0);
            Armor armor = new("Mithril plate body", 20, Slots.Body, attributes, ArmorTypes.Plate);

            Slots slot = Slots.Body;

            Assert.Equal(armor.slots, slot);
        }


        [Fact]
        public void Armor_CheckCorrectSlot_Legs()
        {
            HeroAttributes attributes = new HeroAttributes(1, 2, 0);
            Armor armor = new("Mithril plate legs", 20, Slots.Legs, attributes, ArmorTypes.Plate);

            Slots slot = Slots.Legs;

            Assert.Equal(armor.slots, slot);
        }

        [Fact]
        public void Armor_CheckCorrectArmorType()
        {
            HeroAttributes attributes = new HeroAttributes(1, 2, 0);
            Armor armor = new("Mithril plate legs", 20, Slots.Legs, attributes, ArmorTypes.Plate);

            ArmorTypes armorTypes = ArmorTypes.Plate;

            Assert.Equivalent(armor.ArmorTypes, armorTypes);
        }

        [Fact]
        public void Armor_CheckCorrectArmorAttributes()
        {
            HeroAttributes armorAttributes = new HeroAttributes(1, 2, 0);
            Armor armor = new("Mithril plate legs", 20, Slots.Legs, armorAttributes, ArmorTypes.Plate);

            HeroAttributes attributes_forChecking = new(1, 2, 0);

            Assert.Equivalent(armor.armorAttribute, attributes_forChecking);
        }



    }
}
