using System;
using System.Collections.Generic;
using StarWars.Contracts;
using StarWars.GameObject;

namespace StarWars.Characters
{
    class Player : GameObject, IPlayer
    {
        public int Health
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerable<ICollectible> Inventory
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string name
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Position position
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Race Race
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Attack(ICharacter enemy)
        {
            throw new NotImplementedException();
        }

        public void CollectItem(ICollectible item)
        {
            throw new NotImplementedException();
        }

        public void GetHealth()
        {
            throw new NotImplementedException();
        }

        public void Move(ConsoleKeyInfo pressedKey)
        {
            throw new NotImplementedException();
        }
    }
}
