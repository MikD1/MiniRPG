using System;
using System.Collections.Generic;
using Core.Inventory;

namespace Core
{
    public interface IPlayer
    {
        string Name { get; }
        Health HP { get; }
        int Strength { get; }
        int Money { get; set; }

        void AddItem(IInventoryItem item);
        IReadOnlyCollection<IInventoryItem> Inventory { get; }

        PlayerInfo GetInfo();
    }
}
