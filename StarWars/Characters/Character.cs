using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.Characters
{
   abstract class Character
    {
        private string race;
        private string name;
        private string type;
        private int damage;
        private int health;
        private int energy;

        public abstract string Race { get; set; }
        public abstract string Name { get; set; }
        public  abstract string Type { get; set; }
        public abstract int Damage { get; set; }
        public abstract int Health { get; set; }
        public abstract int Energy { get; set; }
    }
}
