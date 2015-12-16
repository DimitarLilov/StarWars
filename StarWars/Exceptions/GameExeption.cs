using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.Exceptions
{
    public class GameExeption : Exception
    {
        public GameExeption(string message)
            : base(message)
        {
        }
    }
}
