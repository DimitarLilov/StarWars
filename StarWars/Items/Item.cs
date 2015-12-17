using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarWars.GameObject;

namespace StarWars.Items
{
    using StarWars.GameObject;
    public abstract class Item : GameObject
    {
        private string weapon;
        private string armor;

       
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

        public Item(Position position, char symbol) : base(position, symbol)
        {
        }
    }
}