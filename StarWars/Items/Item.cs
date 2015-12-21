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
        public Item(Position position, char symbol) : base(position, symbol)
        {

        }

       
    }
}