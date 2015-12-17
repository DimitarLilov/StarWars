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

namespace StarWars.Engine
{
    public class StarWarsEngine
    {
        private readonly CondoleRenderer renderer;
        private readonly ConsoleReader reader;

        private readonly IList<ICharacter> ceracters;
        private readonly IList<Item> items;
        private IPlayer player;

        public StarWarsEngine(ConsoleReader reader, CondoleRenderer renderer)
        {
            this.renderer = renderer;
            this.reader = reader;
            this.ceracters = new List<ICharacter>();
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
    }
}
