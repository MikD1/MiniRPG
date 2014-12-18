using Core.Inventory;
using System;

namespace Core.GameActions
{
    internal sealed class BuyClothesGameAction : IGameAction
    {
        public void Execute()
        {
            if (_player.Money < _parameters.ClothesPrice)
            {
                _userInteraction.NoMoney();
                return;
            }

            _player.Money -= _parameters.ClothesPrice;

            IClothes clothesItem = InventoryFactory.CreateClothesItem();
            _player.AddItem(clothesItem);
        }

        private readonly IPlayer _player = Game.Instance.Player;
        private readonly IUserInteraction _userInteraction = Game.Instance.UserInteraction;
        private readonly Parameters _parameters = Game.Instance.Parameters;
    }
}
