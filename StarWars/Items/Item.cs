using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.Items
{
    public abstract class Item : GameObject.GameObject
    {
        private string weapon;
        private string armor;

        public Item()
        {
        }

        public string Weapon
        {
            get { return this.weapon; }
            set { this.weapon = value; }
        }

        public string Armor 
        {
            get { return this.armor; }
            set { this.armor = value; } 
        }
    }
}
