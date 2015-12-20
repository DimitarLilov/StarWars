using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarWars.GameObject;

namespace StarWars.Characters.Players
{
    public class Jedi : Player
    {
        private const int JedaiDamage = 400;
        private const int JedaiHealth = 400;
        private const int JedaiArmor = 30;
        public Jedi(Position position, char symbol, string name) : base(position, symbol, JedaiDamage, JedaiHealth, name,0, JedaiArmor)
        {
        }
    }
}
