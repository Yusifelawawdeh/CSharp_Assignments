using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class GameExceptions : SystemException
    {
        public GameExceptions()
        {

        }

        public GameExceptions(string message) : base(message)
        {

        }
    }

    class OutOfBoundsException : GameExceptions
    {
        public OutOfBoundsException()
        {

        }

        public OutOfBoundsException(string message) : base(message)
        {

        }

    }
}
