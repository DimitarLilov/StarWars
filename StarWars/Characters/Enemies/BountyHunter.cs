using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarWars.GameObject;

namespace StarWars.Characters.Enemies
{
    public class BountyHunter : Character
    {
        private const int BountyHunterDamage = 200;
        private const int BountyHunterHealth = 200;
        private const int BountyHunterArmor = 30;

        public BountyHunter(Position position, char symbol, string name) : base(position, symbol, BountyHunterDamage, BountyHunterHealth, name, BountyHunterArmor)
        {
        }
    }
}