using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarWars.Contracts;
using StarWars.GameObject;

namespace StarWars.Characters
{
    using GameObject;
    public abstract class Character : GameObject, ICharacter
    {
        private string name;
        public Character(Position position, char symbol, int damage, int health, string name) : base(position, symbol)
        {
            this.Damage = damage;
            this.Health = health;
            this.Name = name;
        }
        public int Damage { get; }

        public int Health { get; private set; }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name cannot be null, emty or whitespace.");
                }
                this.name = value;
            }
        }

        public void Attack(Character enemy)
        {
            enemy.Health -= this.Damage;
        }



    }
}
