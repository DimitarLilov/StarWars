using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarWars.GameObject;

namespace StarWars.Items
{
    public abstract class Heal : Item
    {
        private int healthRestore;
        private const char SymbolHeal = 'H';
        public Heal(Position position, int healthRestore) : base(position, SymbolHeal)
        {
            this.HealthRestore = healthRestore;
        }

        public int HealthRestore
        {
            get
            {
                return this.healthRestore;
                
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Health restore cannot be negative.");
                }
                this.healthRestore = value;
            }
        }
    }
}
