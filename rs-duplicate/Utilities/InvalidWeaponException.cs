namespace RsDuplicate.Utilities
{
    public class InvalidWeaponException : Exception
    {
        public InvalidWeaponException() { }

        public InvalidWeaponException(string message): base(String.Format("Weapon cannot be equipped: {0}", message)) { }

        public InvalidWeaponException(string message, Exception inner): base(message, inner) { }
    }
}
