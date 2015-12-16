using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.Contracts
{
    public interface IEffectable
    {
        int HealthGained { get; set; }

        int EnergyGained { get; set; }
    }
}
