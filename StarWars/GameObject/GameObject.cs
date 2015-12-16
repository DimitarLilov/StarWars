using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.GameObject
{
    public abstract class GameObject
    {
        private Position position;
        private char symbol;

        public Position Position
        {
            get
            {
                return this.position;
            }
            set
            {
               
            }
        }

        public char Symbol
        {
            get { return this.symbol; }
            set { }
        }
    }
}
