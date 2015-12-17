using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarWars.GameObject;

namespace StarWars.Characters.Enemy
{
    public class StormTrooper : Character
    {
        private const int StormTrooperDamage = 100;
        private const int StormTrooperHealth = 100;
        public StormTrooper(Position position, char symbol, string name) : base(position, symbol, StormTrooperDamage, StormTrooperHealth, name)
        {
        }
    }
}