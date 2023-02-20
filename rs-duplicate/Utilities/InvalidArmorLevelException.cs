namespace RsDuplicate.Utilities
{
    public class InvalidArmorLevelException : Exception
    {
        public InvalidArmorLevelException() { }

        public InvalidArmorLevelException(string message) : base(String.Format("Level is too high, armor cannot be equipped: {0}",message)) { }

        public InvalidArmorLevelException(string message, Exception inner) : base(message, inner) { }
    }
}
