using System;

namespace Core.Inventory
{
    public interface IClothes : IInventoryItem
    {
        int Protection { get; }
    }
}
