using System;
using System.Collections.Generic;
using StarWars.Contracts;
using StarWars.GameObject;
using StarWars.Items;
using StarWars.Items.HealthRestore;
using StarWars.Items.ArmorSet;
using StarWars.Items.WeaponType;
namespace StarWars.Characters
{
    public abstract class Player : Character, IPlayer
    {
        public Player(Position position, char symbol, int damage, int health, string name,int level,int armor) : base(position, symbol, damage, health, name, armor)
        {
            this.Level = level;
        }

        
       
        public int Experience { get; private set; }
        public int Level { get; set; }
        public int Armor { get; set; }

       

        public void LevelUP()
        {

        }

        public void UseItem(Item item)
        {
            switch (item.ToString())
            {
                case "BactaTank":
                    Heal(item as BactaTank);
                    break;
                case "LaserSword":
                    AddDamage(item as LaserSword);
                    break;
                case "Armor":
                    AddArmor(item as Armor);
                    break;
            }
        }
        private void AddArmor(Armor a)
        {
            this.Armor += a.ArmorRestore;
        }

        private void AddDamage(LaserSword ls)
        {
            this.Damage += ls.DamageRestore;
        }

        private void Heal(BactaTank bt)
        {
            this.Health += bt.HealthRestore;
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
