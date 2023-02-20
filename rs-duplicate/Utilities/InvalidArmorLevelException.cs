namespace RsDuplicate.Utilities
{
    public class InvalidArmorLevelException : Exception
    {
        public InvalidArmorLevelException() { }

        public InvalidArmorLevelException(string message) : base(String.Format("Armor type cannot be equipped: {0}",message)) { }

        public InvalidArmorLevelException(string message, Exception inner) : base(message, inner) { }
    }
}
