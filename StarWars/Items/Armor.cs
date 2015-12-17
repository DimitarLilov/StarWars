using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarWars.GameObject;

namespace StarWars.Items
{
    public class Armor : StatItem
    {
        private int armorProtection;

        private int ArmorProtection
        {
            get { return this.armorProtection; }
            set { this.armorProtection = value; }
        }

        public ArmorTypes ArmorType { get; set; }

        public Armor(Position position, char symbol) : base(position, symbol)
        {
        }
    }
}
