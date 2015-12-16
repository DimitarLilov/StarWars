using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.Contracts
{
    interface ICharacter : IAttack, IDestroyable
    {
        string name { get; }

        Position position { get; }
    }
}
