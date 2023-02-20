namespace RsDuplicate.Utilities
{
    public class InvalidWeaponLevelException : Exception
    {
        public InvalidWeaponLevelException() { }

        public InvalidWeaponLevelException(string message): base(String.Format("Level is too high, weapon cannot be equipped: {0}", message)) { }

        public InvalidWeaponLevelException(string message, Exception inner): base(message, inner) { }
    }
}
