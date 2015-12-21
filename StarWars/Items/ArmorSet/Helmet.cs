using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarWars.GameObject;

namespace StarWars.Items.ArmorSet
{
    public class Helmet : Armor
    {
        private const int HelmetArmorRestore = 10;
        public Helmet(Position position, char symbol) : base(position, symbol, HelmetArmorRestore)
        {
        }
    }
}
