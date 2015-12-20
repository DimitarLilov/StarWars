using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarWars.Characters;

namespace StarWars.Contracts
{
    public interface IPlayer : ICharacter, IMoveable, ICollect
    {
        int Experience { get; }
        int Level { get; set; }
        void LevelUP();
    }
}