using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using StarWars.Characters;
using StarWars.Characters.Players;
using StarWars.Contracts;
using StarWars.GameObject;
using StarWars.Items;
using StarWars.UI;
using StarWars.Characters.Enemys;
namespace StarWars.Engine
{
    public class StarWarsEngine
    {
        public const int mapHeight = 30;
        public const int mapWidth = 30;
        
        private const int enemiesNumber = 25;
        private static Random random = new Random();
        private char[,] map = new char[mapHeight,mapWidth];
        
        private readonly CondoleRenderer renderer;
        private readonly ConsoleReader reader;

        private readonly string[] enemyNames =
        {
            "Gocho",
             "Rambo",
             "Stamat",
             "Pepi",
             "Radan",
             "Canko",
             "DartBoyko",
             "Semo"
        };

        private readonly List<Character> enemies = new List<Character>();
        private readonly IList<Item> items;
        private IPlayer player;


        public StarWarsEngine(ConsoleReader reader, CondoleRenderer renderer)
        {
            this.renderer = renderer;
            this.reader = reader;
            this.enemies = MakeEnemy();
            this.items = new List<Item>();
        }

        public bool IsRun { get; private set; }

        public void Run()
        {
            this.IsRun = true;
            PrintLogo();
            this.renderer.WriteLine("");
            var playerName = GetPlayerName();
            var heroe = GetPlayer(playerName);
            renderer.Clear();
            PrintMap(PopulateMap());
            while (this.IsRun)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                    heroe.Move(pressedKey);
                    
                }
            }
        }

        private Player GetPlayer(string name)
        {
            this.renderer.WriteLine("Choose your hero");
            this.renderer.WriteLine("1. Battle Droid (damage : 100, health : 100)");
            this.renderer.WriteLine("2. Rebel (damage : 200, health : 200)");
            this.renderer.WriteLine("3. Gungan Warrior (damage : 300, health : 300)");
            this.renderer.WriteLine("4. Jedi (damage : 400, health : 400)");
            string choiceHeroe = this.reader.ReadLine();
            string[] numberHeroes = { "1", "2", "3", "4" };
            while (!numberHeroes.Contains(choiceHeroe))
            {
                this.renderer.WriteLine("Invalid choice of Heroe");
                choiceHeroe = this.reader.ReadLine();
            }
            Player heroe = null;
            switch (choiceHeroe)
            {
                case "1":
                    heroe = new BattleDroid(new Position(0, 0), 'P', name);
                    break;

                case "2":
                    heroe = new Rebel(new Position(0, 0), 'P', name);
                    break;
                case "3":
                    heroe = new GunganWarrior(new Position(0, 0), 'P', name);
                    break;
                case "4":
                    heroe = new Jedi(new Position(0, 0), 'P', name);
                    break;
            }
            return heroe;
        }
        private string GetPlayerName()
        {
            this.renderer.WriteLine("Please enter your name: ");
            string playerName = this.reader.ReadLine();
            while (string.IsNullOrWhiteSpace(playerName))
            {
                this.renderer.WriteLine("Please name cannot be empty.");
                playerName = this.reader.ReadLine();
            }
            return playerName;
        }



        private void PrintLogo()
        {
            string logo = File.ReadAllText("logo.txt");

            this.renderer.WriteLine(logo);
        }

        private void PrintMap(char[,] map)
        {
            map = PopulateMap();
            map[0, 0] = 'P';
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    builder.Append(map[i, j]);
                }
                builder.AppendLine();
            }
            Console.WriteLine(builder.ToString());
        }

        private char[,] PopulateMap()
        {
            map = CreateMap();

            for (int i = 0; i < enemies.Count; i++)
            {
                map[enemies[i].Position.X, enemies[i].Position.Y] = enemies[i].Symbol;
            }
            return map;
        }

        private char[,] CreateMap()
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    map[i, j] = '.';
                }
            }
            return map;
        }

        private List<Character> MakeEnemy()
        {
            for (int i = 0; i < enemiesNumber; i++)
            {
                string enemyName = enemyNames[random.Next(0, enemyNames.Length)];
                Position enemyPosition = new Position(random.Next(1, mapHeight), random.Next(1, mapWidth));
                bool isEmpty = CheckPosition(enemyPosition);
                while (isEmpty == false)
                {
                    enemyPosition = new Position(random.Next(1, mapHeight), random.Next(1, mapWidth));
                    isEmpty = CheckPosition(enemyPosition);
                }

                int typePick = random.Next(1, 5);
                switch (typePick)
                {
                    case 1:
                        enemies.Add(new BountyHunter(enemyPosition, 'B', enemyName));
                        break;
                    case 2:
                        enemies.Add(new Sith(enemyPosition, 'S', enemyName));
                        break;
                    case 3:
                        enemies.Add(new SIthAPprentice(enemyPosition, 'A', enemyName));
                        break;
                    case 4:
                        enemies.Add(new StormTrooper(enemyPosition, 'T', enemyName));
                        break;
                }
            }
            return enemies;
        }

        private bool CheckPosition(Position pos)
        {
            bool isEmpty = true;

            for (int i = 0; i < enemies.Count; i++)
            {
                if (enemies[i].Position.X == pos.X && enemies[i].Position.Y == pos.Y)
                {
                    isEmpty = false;
                }
            }
            return isEmpty;
        }
    }
}
