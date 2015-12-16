using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.Contracts
{
    interface ICollect
    {
        void CollectItem(ICollectible item);

        IEnumerable<ICollectible> Inventory { get; }  
    }
}
