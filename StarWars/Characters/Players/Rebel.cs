using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarWars.GameObject;

namespace StarWars.Characters.Players
{
    public class Rebel : Player
    {
        private const int RebelDamage = 200;
        private const int RebelHealth = 200;
        public Rebel(Position position, char symbol, string name) : base(position, symbol, RebelDamage, RebelHealth, name)
        {
        }
    }
}
