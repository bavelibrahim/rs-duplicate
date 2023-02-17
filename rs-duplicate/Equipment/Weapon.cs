using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RsDuplicate.Equipment
{
    // Setting flag here so it is possible to set valid 
    // weapon types for each hero. 
    [Flags]
    enum WeaponTypes
    {
        Axe = 0,
        Bow = 1,
        Dagger = 2,
        Hammer = 4,
        Staff = 8,
        Sword = 16,
        Wand = 32
    }

    internal class Weapon : Items
    {
        private int weaponDamage;
        private WeaponTypes weaponType;

        
        public int WeaponDamage { get => weaponDamage;  set => weaponDamage = value;  }
        public WeaponTypes WType { get => weaponType;  set => weaponType = value;  }


        public Weapon(string name, int requiredLevel, Slots slots, int weaponDamage, WeaponTypes weaponTypes) : base(name, requiredLevel, slots)
        {
            WeaponDamage = weaponDamage;
            WType = weaponTypes;
        }

        

    }
}
