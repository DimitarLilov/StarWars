using System;
using StarWars.GameObject;

namespace StarWars.Items
{
    public class Armor: Item
    {
        private int armorRestore;
        private const char SymbolArmor = 'C'; 
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
