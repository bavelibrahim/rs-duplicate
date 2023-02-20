namespace RsDuplicate.Utilities
{
    public class InvalidArmorException : Exception
    {
        public InvalidArmorException() { }

        public InvalidArmorException(string message) : base(String.Format("Armor type cannot be equipped: {0}",message)) { }

        public InvalidArmorException(string message, Exception inner) : base(message, inner) { }
    }
}
