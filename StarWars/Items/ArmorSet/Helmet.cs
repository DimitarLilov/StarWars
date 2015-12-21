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
        private const int HelmetArmorRestore = 15;
        public Helmet(Position position) : base(position, HelmetArmorRestore)
        {
        }
    }
}
