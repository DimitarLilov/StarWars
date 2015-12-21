using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarWars.GameObject;

namespace StarWars.Items.HealthRestore
{
    public class BactaTank : Heal
    {
        private const int BactaTankHealthRestore = 50;
        public BactaTank(Position position, char symbol) : base(position, symbol, BactaTankHealthRestore)
        {
        }
        public override string ToString()
        {
            return "BactaTank";
        }
    }
}
