using System;

namespace Core.Inventory
{
    public interface IInventoryItem
    {
        InventoryType Type { get; }
        string Name { get; }
    }
}
