using System;

namespace StarWars.Contracts
{
    public interface IMoveable
    {
        void Move(ConsoleKeyInfo pressedKey);
    }
}