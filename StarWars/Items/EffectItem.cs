using StarWars.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.Items
{
    public abstract class EffectItem : Item, IEffectable
    {
        private int healthGained;
        private int energyGained;

        public int HealthGained 
        {
            get { return this.healthGained; }
            set { this.healthGained = value; } 
        }

        public int EnergyGained 
        {
            get { return this.energyGained; }
            set { this.energyGained = value; } 
        }
    }
}
