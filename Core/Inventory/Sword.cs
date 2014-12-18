using System;

namespace Core.Inventory
{
    internal sealed class Sword : IWeapon
    {
        internal Sword(string name, int damage)
        {
            if (string.IsNullOrEmpty(name))
            {
                Name = "Noname Sword";
            }
            else
            {
                Name = name;
            }

            Damage = damage > 0 ? damage : 0;
        }

        public InventoryType Type
        {
            get
            {
                return InventoryType.Weapon;
            }
        }
        public string Name { get; private set; }
        public int Damage { get; private set; }
    }
}
