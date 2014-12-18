using Core.Inventory;
using System;
using System.Collections.Generic;

namespace Core
{
    public struct PlayerInfo
    {
        public string Name { get; set; }
        public int MaxHP { get; set; }
        public int HP { get; set; }
        public int Strength { get; set; }
        public int Money { get; set; }
        public IReadOnlyCollection<IInventoryItem> Inventory { get; set; }
    }
}
