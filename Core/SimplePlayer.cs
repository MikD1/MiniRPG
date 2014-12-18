using Core.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Core
{
    internal sealed class SimplePlayer : IPlayer
    {
        internal SimplePlayer(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                Name = "Mr. Nobody";
            }
            else
            {
                Name = name;
            }

            HP = new Health(0);
            HP.Max = Game.Instance.Parameters.PlayerStartMaxHealth;
            HP.Current = Game.Instance.Parameters.PlayerStartHealth;
            Strength = Game.Instance.Parameters.PlayerStartStrength;
            Money = Game.Instance.Parameters.PlayerStartMoney;
        }

        public string Name { get; private set; }
        public Health HP { get; private set; }
        public int Strength { get; private set; }
        public int Money
        {
            get
            {
                return _money;
            }
            set
            {
                _money = value > 0 ? value : 0;
            }
        }

        public void AddItem(IInventoryItem item)
        {
            switch (item.Type)
            {
                case InventoryType.Weapon:
                    Strength += ((IWeapon)item).Damage;
                    break;

                case InventoryType.Clothes:
                    HP.Max += ((IClothes)item).Protection;
                    break;
            }

            _inventory.Add(item);
        }
        public IReadOnlyCollection<IInventoryItem> Inventory
        {
            get
            {
                return _inventory;
            }
        }

        public PlayerInfo GetInfo()
        {
            PlayerInfo info = new PlayerInfo
            {
                Name = this.Name,
                MaxHP = HP.Max,
                HP = HP.Current,
                Strength = this.Strength,
                Money = this.Money,
                Inventory = this.Inventory
            };

            return info;
        }

        private int _money;
        private readonly List<IInventoryItem> _inventory = new List<IInventoryItem>();
    }
}
