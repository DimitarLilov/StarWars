using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarWars.GameObject;

namespace StarWars.Items.ArmorSet
{
    public class Gloves : Armor
    {
        private const int GloversArmorRestore = 10;
        public Gloves(Position position, char symbol) : base(position, symbol, GloversArmorRestore)
        {
        }
    }
}
