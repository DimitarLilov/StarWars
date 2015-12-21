using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarWars.Characters;

namespace StarWars.Contracts
{
    public interface IPlayer : ICharacter, IMoveable
    {
        int Experience { get; }
        int Level { get; set; }
        int Armor { get; set; }
        void LevelUP();
    }
}