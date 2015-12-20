using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarWars.GameObject;

namespace StarWars.Characters.Players
{
    public class GunganWarrior : Player
    {
        private const int GunganWarriorDamage = 300;
        private const int GunganWarriorHealth = 300;

        public GunganWarrior(Position position, char symbol, string name) : base(position, symbol, GunganWarriorDamage, GunganWarriorHealth, name,0)
        {
        }
    }
}