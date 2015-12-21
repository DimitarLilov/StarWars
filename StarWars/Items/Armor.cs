using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarWars.GameObject;

namespace StarWars.Items
{
    public abstract class Armor: Item
    {
        private int armorRestore;
        public Armor(Position position, char symbol, int armorRestore) : base(position, symbol)
        {
        }

        public int ArmorRestore {
            get
            {
                return this.armorRestore;
                
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Armor restore cannot be negative.");
                }
                this.armorRestore = value;
            }
        }
    }
}
