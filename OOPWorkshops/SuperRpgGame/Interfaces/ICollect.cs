using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperRpgGame.Items;

namespace SuperRpgGame.Interfaces
{
    public interface ICollect
    {
        IEnumerable<Item> Inventory { get; }
        void AddItemToInventory(Item item);
    }
}
