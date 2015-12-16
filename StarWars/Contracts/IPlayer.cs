using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarWars.Characters;

namespace StarWars.Contracts
{
    interface IPlayer : ICharacter, IMovable, IHeal, ICollect
    {
        Race Race { get; }
    }
}
