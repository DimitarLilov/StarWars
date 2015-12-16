using StarWars.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.Items
{
    public abstract class StatItem : Item, ICollect
    {
        private int stamina;
        private int agility;
        private int strenght;
        private int intellect;


        public int Stamina 
        {
            get { return this.stamina; }
            set { this.stamina = value; } 
        }

        public int Agility 
        {
            get { return this.agility; }
            set { this.agility = value; } 
        }

        public int Strenght 
        {
            get { return this.strenght; }
            set { this.strenght = value; } 
        }

        public int Intellct 
        {
            get { return this.intellect; }
            set { this.intellect = value; } 
        }
    }
}
