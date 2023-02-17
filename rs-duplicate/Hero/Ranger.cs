using RsDuplicate.Equipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RsDuplicate.Hero
{
    internal class Ranger : HeroTemplate
    {
        // Start Values for a Level 1 Ranger


        private int Strength { get; set; }  
        private int Dexterity { get; set; }
        private int Intelligence { get; set; }

        WeaponTypes WeaponType { get; set; }
        ArmorTypes Armortype { get; set; }


        public Ranger(string Name) : base(Name) 
        {
            Strength = 1;
            Dexterity = 7;
            Intelligence = 1;

            WeaponType = WeaponTypes.Bow;
            Armortype = ArmorTypes.Leather | ArmorTypes.Mail;

        }
    }
}
