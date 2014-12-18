using Core.Inventory;
using System;

namespace Core.GameActions
{
    internal sealed class BuyWeaponGameAction : IGameAction
    {
        public void Execute()
        {
            if (_player.Money < _parameters.WeaponPrice)
            {
                _userInteraction.NoMoney();
                return;
            }

            _player.Money -= _parameters.WeaponPrice;

            IWeapon weaponItem = InventoryFactory.CreateWeaponItem();
            _player.AddItem(weaponItem);
        }

        private readonly IPlayer _player = Game.Instance.Player;
        private readonly IUserInteraction _userInteraction = Game.Instance.UserInteraction;
        private readonly Parameters _parameters = Game.Instance.Parameters;
    }
}
