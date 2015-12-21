using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarWars.GameObject;

namespace StarWars.Items.ArmorSet
{
    public class Pants : Armor
    {
        private const int PantsArmorRestore = 10;
        public Pants(Position position, char symbol) : base(position, symbol, PantsArmorRestore)
        {
        }
    }
}
