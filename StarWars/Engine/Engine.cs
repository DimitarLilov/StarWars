using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarWars.Contracts;
using StarWars.Items;
using StarWars.UI;

namespace StarWars.Engine
{
    public class Engine
    {
        private readonly CondoleRenderer renderer;
        private readonly ConsoleReader reader;

        private readonly IList<ICharacter> ceracters;
        private readonly IList<Item> items;

        public Engine(ConsoleReader reader, CondoleRenderer renderer)
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
            while (this.IsRun)
            {
                PlayerControls();
            }
        }

            private static void PlayerControls()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }
                if (pressedKey.Key == ConsoleKey.LeftArrow || pressedKey.Key == ConsoleKey.A)
                {
                    if (playerPosition - 1 > 0)
                    {
                        playerPosition--;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow || pressedKey.Key == ConsoleKey.D)
                {
                    if (playerPosition + 1 < Width)
                    {
                        playerPosition++;
                    }
                }
            }
        }
    }
}