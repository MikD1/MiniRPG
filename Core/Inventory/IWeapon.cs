using System;

namespace Core.Inventory
{
    public interface IWeapon : IInventoryItem
    {
        int Damage { get; }
    }
}
