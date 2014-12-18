using System;

namespace Core.Inventory
{
    internal sealed class Hat : IClothes
    {
        internal Hat(string name, int protection)
        {
            if (string.IsNullOrEmpty(name))
            {
                Name = "Unknown hat (made in China)";
            }
            else
            {
                Name = name;
            }

            Protection = protection > 0 ? protection : 0;
        }

        public InventoryType Type
        {
            get
            {
                return InventoryType.Clothes;
            }
        }
        public string Name { get; private set; }
        public int Protection { get; private set; }
    }
}
