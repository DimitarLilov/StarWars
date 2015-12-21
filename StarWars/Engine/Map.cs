using System;
using System.Collections.Generic;
using StarWars.Characters;
using StarWars.Characters.Enemies;
using StarWars.Items;
using StarWars.GameObject;
namespace StarWars.Engine
{
    public static class Map
    {
        private static int mapHeight = 30;
        private static int mapWidth = 30;
        private static int enemiesNumber = 25;
        private static int itemsNumber = 15;
        private static List<Character> enemies;
        private static List<Item> items;
        private static Random random = new Random();
        private static readonly string[] enemyNames =
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

        private static void FillEnemyList()
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
        }


        private static bool CheckPosition(Position pos)
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
