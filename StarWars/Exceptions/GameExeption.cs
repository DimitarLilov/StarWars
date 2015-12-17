using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.Exceptions
{
    using System;
    public class GameExeption : Exception
    {
        public GameExeption(string message)
            : base(message)
        {
        }
    }
}
