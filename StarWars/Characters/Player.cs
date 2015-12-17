using System;
using System.Collections.Generic;
using StarWars.Contracts;
using StarWars.GameObject;
using StarWars.Items;

namespace StarWars.Characters
{
    public abstract class Player : Character, IPlayer
    {
        public Player(Position position, char symbol, int damage, int health, string name) : base(position, symbol, damage, health, name)
        {
        }

        public void CollectItem(ICollectible item)
        {
          
        }

        IEnumerable<ICollectible> ICollect.Inventory { get; }
       
        public int Experience { get; private set; }
        public int Armor { get; }

        public void LevelUP()
        {

        }
        public void Move()
        {

        }
        public void AddItem(Item item)
        {

        }
    }
}
