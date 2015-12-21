using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarWars.GameObject;

namespace StarWars.Items.WeaponType
{
    public class LaserSword : Weapon
    {
        private const int LaserSwordDamageRestore = 30;
        public LaserSword(Position position, char symbol) : base(position, symbol, LaserSwordDamageRestore)
        {
        }

        public override string ToString()
        {
            return "LaserSword";
        }

    }
}
