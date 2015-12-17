using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.Exception
{
    using System;
    public class ObjectOutOfMap : Exception
    {
        public ObjectOutOfMap(string massage) : base(massage)
        {

        }
    }
}
