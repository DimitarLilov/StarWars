using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarWars.Contracts;
using StarWars.GameObject;
using StarWars.UI;

namespace StarWars.Characters
{
    using GameObject;
    public abstract class Character : GameObject, ICharacter
    {
        private string name;
        private int armor;
        private CondoleRenderer rende = new CondoleRenderer();
        public Character(Position position, char symbol, int damage, int health, string name, int armor) : base(position, symbol)
        {
            this.Damage = damage;
            this.Health = health;
            this.Name = name;
            this.Armor = armor;
        }

        public int Armor { get; protected set; }
        
        public int Damage { get; protected set; }

        public int Health { get; protected set; }

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
            enemy.Health -= (this.Damage - this.Armor);
            if (enemy.Health < 0)
            {
                enemy.Health = 0;
            }
            rende.WriteLine("{0} Attacked {1} for {2}", this.Name, enemy.Name, this.Damage);
        }



    }
}
