using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarWars.GameObject;

namespace StarWars.Items.ArmorSet
{
    public class Boots : Armor
    {
        private const int BootsArmorRestore = 10;
        public Boots(Position position, char symbol) : base(position, symbol, BootsArmorRestore)
        {
        }
    }
}
