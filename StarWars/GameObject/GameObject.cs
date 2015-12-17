using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarWars.Exception;

namespace StarWars.GameObject
{
    public abstract class GameObject
    {
        private Position position;
        private char symbol;
        public Position Position
        {
            get { return this.position; }
            set
            {
                if (value.X < 0 || value.Y < 0)
                {
                    throw new ObjectOutOfMap("Object OutOf Map");
                }
                this.position = value;
            }
        }

        public char Symbol
        {
            get { return this.symbol; }
            set { this.symbol = value; }
        }
        protected GameObject(Position position, char symbol)
        {
            this.Position = position;
            this.Symbol = symbol;
        }

    }
}
