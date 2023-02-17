using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RsDuplicate.Utilities
{
    internal class InvalidArmorException : Exception
    {
        public InvalidArmorException() { }

        public InvalidArmorException(string message) : base(String.Format("Armor type cannot be equipped: {0}",message)) { }

        public InvalidArmorException(string message, Exception inner) : base(message, inner) { }
    }
}
