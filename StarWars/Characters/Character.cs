using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarWars.Contracts;
using StarWars.GameObject;

namespace StarWars.Characters.Enemy
{
    using GameObject;
    public abstract class Character : GameObject, ICharacter
    {
        public Character(Position position, char symbol, int damage, int health, string name) : base(position, symbol)
        {
            this.Damage = damage;
            this.Health = health;
            this.Name = name;
        }
        public int Damage { get; private set; }

        public int Health { get; private set; }
        public string Name { get; private set; }

        public void Attack(Character enemy)
        {
            enemy.Health -= this.Damage;
        }



    }
}
