using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.Contracts
{
    interface IMovable
    {
        void Move(ConsoleKeyInfo pressedKey);
    }
}
