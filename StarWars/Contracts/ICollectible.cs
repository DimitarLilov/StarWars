using StarWars.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.Contracts
{
    public interface ICollectible
    {
        StatItem State { get; set; }
    }
}
