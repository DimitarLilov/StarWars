using StarWars.Engine;
using StarWars.Exceptions;

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
                if (value.X < 0
                    || value.Y < 0
                    || value.X >= StarWarsEngine.mapHeight
                    || value.Y >= StarWarsEngine.mapWidth)
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
