
namespace RsDuplicate.Equipment
{
    // Setting flag here so it is possible to set valid 
    // weapon types for each hero. 
    [Flags]
    public enum WeaponTypes
    {
        Axe = 0,
        Bow = 1,
        Dagger = 2,
        Hammer = 4,
        Staff = 8,
        Sword = 16,
        Wand = 32
    }

    public class Weapon : Items
    {
        private int weaponDamage;
        private WeaponTypes weaponType;

        public int WeaponDamage { get => weaponDamage;  set => weaponDamage = value;  }
        public WeaponTypes WeaponType { get => weaponType;  set => weaponType = value;  }


        public Weapon(string name, int requiredLevel, Slots slots, int weaponDamage, WeaponTypes weaponTypes) : base(name, requiredLevel, slots)
        {
            //Weapondamage and weapontype is set when a new weapon is created.
            WeaponDamage = weaponDamage;
            WeaponType = weaponTypes;
        }

        

    }
}
