using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
