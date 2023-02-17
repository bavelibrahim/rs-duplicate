using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RsDuplicate.Utilities
{
    internal class InvalidWeaponException : Exception
    {
        public InvalidWeaponException() { }

        public InvalidWeaponException(string message): base(String.Format("Weapon cannot be equipped: {0}", message)) { }

        public InvalidWeaponException(string message, Exception inner): base(message, inner) { }
    }
}
