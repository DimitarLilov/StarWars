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
        
        public void AddItem(Item item)
        {

        }

        public void Move(ConsoleKeyInfo pressedKey)
        {
            while (Console.KeyAvailable)
            {
                Console.ReadKey(true);
            }
            if (pressedKey.Key == ConsoleKey.LeftArrow || pressedKey.Key == ConsoleKey.A)
            {
                this.Position = new Position(this.Position.X,this.Position.Y-1);
            }
            else if (pressedKey.Key == ConsoleKey.RightArrow || pressedKey.Key == ConsoleKey.D)
            {
                this.Position = new Position(this.Position.X , this.Position.Y + 1);
            }
            if (pressedKey.Key == ConsoleKey.UpArrow || pressedKey.Key == ConsoleKey.W)
            {
                this.Position = new Position(this.Position.X - 1, this.Position.Y );
            }
            else if (pressedKey.Key == ConsoleKey.DownArrow || pressedKey.Key == ConsoleKey.S)
            {
                this.Position = new Position(this.Position.X + 1, this.Position.Y);
            }
        }
    }
}
