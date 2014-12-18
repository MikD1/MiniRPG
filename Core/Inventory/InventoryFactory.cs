using System;

namespace Core.Inventory
{
    public static class InventoryFactory
    {
        public static IClothes CreateClothesItem()
        {
            Random random = new Random();
            Parameters _parameters = Game.Instance.Parameters;

            int protection = random.Next(_parameters.ClothesMinBonus, _parameters.ClothesMaxBonus + 1);
            return new Hat(string.Empty, protection);
        }
        public static IWeapon CreateWeaponItem()
        {
            Random random = new Random();
            Parameters _parameters = Game.Instance.Parameters;

            int damage = random.Next(_parameters.WeaponMinBonus, _parameters.WeaponMaxBonus + 1);
            return new Sword(string.Empty, damage);
        }
    }
}
