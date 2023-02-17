using RsDuplicate.Equipment;
using RsDuplicate.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RsDuplicate.Hero
{
    internal class HeroTemplate
    {

        public int tempStrength;
        public int tempDexterity;
        public int tempIntelligence;

        public string Name;
        public int Level;
        private double DamageAttribute;
        public double damageattribute { get => DamageAttribute; set => DamageAttribute = value; }

        public Dictionary<Slots, Items?> Equipment = new Dictionary<Slots, Items?>();
        public HeroAttributes heroAttributes;

        public List<WeaponTypes> weaponTypes;
        public List<ArmorTypes> armorTypes;

        //Constructor for the Hero, creates a hero with a Name ONLY - as requested.
        public HeroTemplate(string name)
        {

            Name = name;
            Level = 1;

            weaponTypes = new List<WeaponTypes>();
            armorTypes = new List<ArmorTypes>();

            heroAttributes = new HeroAttributes(1, 1, 1);

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
                    heroAttributes.LevelUp(2, 3, 1); break;

                case Ranger:
                    heroAttributes.LevelUp(5, 1, 1); break;

                case Rogue:
                    heroAttributes.LevelUp(4, 1, 1); break;

                default: break; // This shouldn't happen, but will return the hero if it does for some reason....
            }
        }


        // EquipArmor equips armor for the hero.
        // It was possible to fuse both the EquipArmor- and EquipWeapon and pass in Item as a paramaeter
        // However i wanted it to be like this because it was easier to follow the code structure
        public void EquipArmor(Armor armor)
        {
            if (armorTypes.Contains(armor.armorTypes))
            {
                Equipment.Remove(armor.slots);
                Equipment.Add(armor.slots, armor);
            }
            else
            {
                throw new InvalidArmorException();
            }
        }


        public void EquipWeapon(Weapon weapon)
        {
            Console.WriteLine("The weapon type: " + weapon.WType);
            Console.WriteLine("The valid weapon type: " + weaponTypes);

            foreach (WeaponTypes wType in weaponTypes)
            {
                if (weapon.WType == wType)
                {
                    Equipment.Remove(Slots.Weapon);
                    Equipment.Add(Slots.Weapon, weapon);
                }
            }
        }

        public double Damage()
        {
            Weapon weapon = Equipment[Slots.Weapon] as Weapon;
            double DamageValue;

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

            if (weapon != null)
            {
                return weapon.WeaponDamage * (1 + (DamageAttribute/100));
            } else { return DamageAttribute; } //Return one damage if there are no weapons Equipped.
        }

        public int TotalAttributes()
        {

            int TotalAttributes =
                heroAttributes.Strength +
                heroAttributes.Intelligence +
                heroAttributes.Dexterity;

            // Iterating through each Equipment that is
            foreach (Items item in Equipment.Values)
            {
                if (item is Armor)
                {
                    Armor armor = (Armor)item;

                    TotalAttributes += 
                        (armor.armorAttributes.Strength + 
                        armor.armorAttributes.Dexterity + 
                        armor.armorAttributes.Intelligence);

                    tempStrength = heroAttributes.Strength + armor.armorAttributes.Strength;
                    tempDexterity = heroAttributes.Dexterity + armor.armorAttributes.Dexterity;
                    tempIntelligence = heroAttributes.Intelligence + armor.armorAttributes.Intelligence;
                }
            }



            return TotalAttributes;
        }

        public void Display()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine(Name);
            builder.AppendLine(GetType().Name);
            builder.AppendLine(Level.ToString());
            builder.AppendLine(tempStrength.ToString());
            builder.AppendLine(tempDexterity.ToString());
            builder.AppendLine(tempIntelligence.ToString());
            builder.AppendLine(Damage().ToString());

            Console.WriteLine(builder.ToString());
        }


    }


}
