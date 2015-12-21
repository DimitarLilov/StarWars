using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarWars.Items;

namespace StarWars.Contracts
{
    public interface ICollect
    {
        IEnumerable<Item> Inventory { get; }

        void CollectItem(Item item);
        
    }
}
