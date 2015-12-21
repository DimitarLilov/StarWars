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
        public BactaTank(Position position) : base(position, BactaTankHealthRestore)
        {
        }
        public override string ToString()
        {
            return "BactaTank";
        }
    }
}
