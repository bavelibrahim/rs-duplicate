namespace RsDuplicate.Utilities
{
    public class InvalidArmorTypeException : Exception
    {
        public InvalidArmorTypeException() { }

        public InvalidArmorTypeException(string message) : base(String.Format("Armor type cannot be equipped: {0}",message)) { }

        public InvalidArmorTypeException(string message, Exception inner) : base(message, inner) { }
    }
}
