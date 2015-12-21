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

        public Heal(Position position, char symbol, int healthRestore) : base(position, symbol)
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
