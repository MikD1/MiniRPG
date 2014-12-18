using System;

namespace Core.GameActions
{
    internal sealed class HealingGameAction : IGameAction
    {
        public void Execute()
        {
            if (_player.HP.IsFull)
            {
                _userInteraction.HealingNotRequired();
                return;
            }

            if (_player.Money < _parameters.HealingPrice)
            {
                _userInteraction.NoMoney();
                return;
            }

            _player.Money -= _parameters.HealingPrice;
            _player.HP.Current += _parameters.HealingRate;
        }

        private readonly IPlayer _player = Game.Instance.Player;
        private readonly IUserInteraction _userInteraction = Game.Instance.UserInteraction;
        private readonly Parameters _parameters = Game.Instance.Parameters;
    }
}
