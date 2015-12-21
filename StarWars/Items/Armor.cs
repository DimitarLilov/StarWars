using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using StarWars.GameObject;

namespace StarWars.Items
{
    public abstract class Armor: Item
    {
        private int armorRestore;
        private const char SymbolArmor = 'A'; 
        public Armor(Position position, int armorRestore) : base(position, SymbolArmor)
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


        public override string ToString()
        {
            return "Armor";
        }

    }
}
