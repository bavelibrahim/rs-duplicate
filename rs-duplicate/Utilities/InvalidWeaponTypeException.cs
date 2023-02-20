namespace RsDuplicate.Utilities
{
    public class InvalidWeaponTypeException : Exception
    {
        public InvalidWeaponTypeException() { }

        public InvalidWeaponTypeException(string message): base(String.Format("Weapon cannot be equipped: {0}", message)) { }

        public InvalidWeaponTypeException(string message, Exception inner): base(message, inner) { }
    }
}
