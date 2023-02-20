using RsDuplicate.Equipment;
using RsDuplicate.Utilities;
using System.Text;

namespace RsDuplicate.Hero
{
    public class HeroTemplate
    {

        public string Name;
        public int Level = 1;
        public double DamageAttribute;

        public HeroAttributes heroAttributes = new(0, 0, 0);
        public Dictionary<Slots, Items> Equipment;
        public List<Items> items = new List<Items>();
        private List<WeaponTypes> weaponTypes;
        private List<ArmorTypes> armorTypes;


        //Constructor for the Hero, creates a hero with a Name ONLY - as requested.

        public HeroTemplate(string name)
        {

            Name = name;
            Level = 1;

            DamageAttribute = 1;

            weaponTypes = Enum.GetValues(typeof(WeaponTypes)).Cast<WeaponTypes>().ToList();
            armorTypes = Enum.GetValues(typeof(ArmorTypes)).Cast<ArmorTypes>().ToList();
            Equipment = new();

            try
            {
                Equipment.Add(Slots.Weapon, null);
                Equipment.Add(Slots.Head, null);
                Equipment.Add(Slots.Body, null);
                Equipment.Add(Slots.Legs, null);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Null reference {0}", e.Source);
            }
        }
        public void LevelUp()
        {

            switch (this)
            {
                // Incrementing Attribute-Values for each Hero-type.
                case Mage:
                    heroAttributes.LevelUp(1, 1, 5); break;

                case Warrior:
                    heroAttributes.LevelUp(3, 2, 1); break;

                case Ranger:
                    heroAttributes.LevelUp(1, 5, 1); break;

                case Rogue:
                    heroAttributes.LevelUp(1, 4, 1); break;

                default: break; // This shouldn't happen, but will return the hero if it does for some reason....
            }

            Level += 1;
        }


        // EquipArmor equips armor for the hero.
        // It was possible to fuse both the EquipArmor- and EquipWeapon and pass in Item as a paramaeter
        // However i wanted it to be like this because it was easier to follow the code structure
        public void EquipArmor(Armor armor)
        {
            if (armor.requiredLevel > Level)
            {
                throw new InvalidArmorLevelException();
            }
            else if (!armorTypes.Contains(armor.ArmorTypes))
            {
                throw new InvalidArmorTypeException();
            }
            else if (armorTypes.Contains(armor.ArmorTypes)) {
                Console.WriteLine("Hello dude!");

                Equipment.Remove(armor.slots);
                Equipment.Add(armor.slots, armor);
            }
            
        }

        public void EquipWeapon(Weapon weapon)
        {

            //Console.WriteLine("Weapon type for mage is: " + weapon.WeaponType);

            if (weapon.requiredLevel > Level)
            {
                throw new InvalidWeaponLevelException();
            }
            else if (!weaponTypes.Contains(weapon.WeaponType))
            {
                throw new InvalidWeaponTypeException();
            }
            else {
                Equipment.Remove(Slots.Weapon);
                Equipment.Add(Slots.Weapon, weapon);
            }
        }

        public double Damage()
        {

            double DamageValue = 1;

            if (Equipment[Slots.Weapon] != null) {
                Weapon? weapon = Equipment[Slots.Weapon] as Weapon;
                DamageValue = weapon.WeaponDamage;
            }

            switch (this)
            {
                case Mage:
                    DamageAttribute = heroAttributes.Intelligence;
                    break;
                case Ranger:
                    DamageAttribute = heroAttributes.Dexterity;
                    break;
                case Rogue:
                    DamageAttribute = heroAttributes.Dexterity;
                    break;
                case Warrior:
                    DamageAttribute = heroAttributes.Strength;
                    break;
            }

            if (Equipment[Slots.Weapon] != null)
            {
                return DamageValue * (1 + (DamageAttribute/100));
            } else { return DamageAttribute; } //Return Damageattribute damage if there are no weapons Equipped.
        }

        public int TotalAttributes()
        {

            int TotalAttributes = 0;

            foreach (Items item in Equipment.Values) 
            {
                Armor? armor = item as Armor;

                if (armor != null)
                {
                    heroAttributes.Strength += armor.armorAttribute.Strength;
                    heroAttributes.Dexterity += armor.armorAttribute.Dexterity;
                    heroAttributes.Intelligence += armor.armorAttribute.Intelligence;
                }
            }

            TotalAttributes += heroAttributes.Strength + heroAttributes.Dexterity + heroAttributes.Intelligence;

            return TotalAttributes;
        }

        public StringBuilder Display()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine("Hero Name: " + Name);
            builder.AppendLine("Hero Class: " + GetType().Name);
            builder.AppendLine("Hero Level: " + Level.ToString());
            builder.AppendLine("Total Strength: " + heroAttributes.Strength.ToString());
            builder.AppendLine("Total Dexterity: " + heroAttributes.Dexterity.ToString());
            builder.AppendLine("Total Intelligence: " + heroAttributes.Intelligence.ToString());
            builder.AppendLine("Hero Damage: " + Damage().ToString());

            return builder;
        }
    }
}
