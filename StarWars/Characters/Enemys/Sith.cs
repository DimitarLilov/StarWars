using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarWars.GameObject;

namespace StarWars.Characters.Enemy
{
    public class Sith : Character
    {
        private const int SithDamage = 400;
        private const int SithHealth = 400;
        public Sith(Position position, char symbol, string name) : base(position, symbol, SithDamage, SithHealth, name)
        {
        }
    }
}
