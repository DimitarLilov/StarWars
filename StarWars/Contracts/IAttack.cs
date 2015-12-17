using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarWars.Characters;


namespace StarWars.Contracts
{

    public interface IAttack
    {
        int Damage { get; }

        void Attack(Character enemy);
    }
}
