using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    class ArmurerieException : Exception
    {
        public ArmurerieException(String message) : base(message)
        {
            Console.WriteLine(message);
        }
    }
}
