using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarWars.GameObject;

namespace StarWars.Characters.Enemy
{
    public class SIthAPprentice : Character
    {
        private const int SIthAPprenticeDamage = 300;
        private const int SIthAPprenticeHealth = 300;

        public SIthAPprentice(Position position, char symbol, string name) : base(position, symbol, SIthAPprenticeDamage, SIthAPprenticeHealth, name)
        {
        }
    }
}