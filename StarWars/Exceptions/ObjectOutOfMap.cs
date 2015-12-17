using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.Exceptions
{
    using System;
    public class ObjectOutOfMap : Exception
    {
        public ObjectOutOfMap(string massage) : base(massage)
        {

        }
    }
}
