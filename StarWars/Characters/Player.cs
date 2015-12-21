using System;
using StarWars.Contracts;
using StarWars.GameObject;
using StarWars.Items;
using StarWars.Items.HealthRestore;
using StarWars.Items.WeaponType;
namespace StarWars.Characters
{
    public abstract class Player : Character, IPlayer
    {
        private const int TargetHealth = 500;
        private const int TargetDamage = 500;
        private const int TargetArmor = 500;
        public Player(Position position, char symbol, int damage, int health, string name,int level,int armor) : base(position, symbol, damage, health, name, armor)
        {
            this.Level = level;
        }

        public int Experience { get; set; }
        public int Level { get; set; }


        public void LevelUP()
        {
            if (Experience >= 100)
            {
                Level++;
                Health += 5;
                Damage += 5;
                Experience = 0;
            }

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
            if (Armor < TargetArmor)
            {
                this.Armor += a.ArmorRestore;
            }            
        }

        private void AddDamage(LaserSword ls)
        {
            if (Damage < TargetDamage)
            {
                this.Damage += ls.DamageRestore;
            }
            
        }

        private void Heal(BactaTank bt)
        {
            if (Health < TargetHealth)
            {
                this.Health += bt.HealthRestore;
            }
            
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
