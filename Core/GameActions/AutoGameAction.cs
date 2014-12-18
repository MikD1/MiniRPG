using System;

namespace Core.GameActions
{
    internal sealed class AutoGameAction : IGameAction
    {
        public void Execute()
        {
            int fightWinRate = _parameters.FightWinBaseRate + _player.Strength * _parameters.FightWinStrengthRate;
            IGameAction gameAction = null;

            if (_player.Money >= _parameters.HealingPrice && !_player.HP.IsFull)
            {
                _userInteraction.AutoActionMessage("Healing");
                gameAction = new HealingGameAction();
            }
            else if (_player.Money >= _parameters.WeaponPrice && fightWinRate < _parameters.FightWinMaxRate)
            {
                _userInteraction.AutoActionMessage("Need more weapons");
                gameAction = new BuyWeaponGameAction();
            }
            else if (_player.Money >= _parameters.ClothesPrice)
            {
                _userInteraction.AutoActionMessage("I have more hats");
                gameAction = new BuyClothesGameAction();
            }
            else
            {
                _userInteraction.AutoActionMessage("Attack!!!!!1");
                gameAction = new AttackGameAction();
            }

            gameAction.Execute();
        }

        private readonly IPlayer _player = Game.Instance.Player;
        private readonly IUserInteraction _userInteraction = Game.Instance.UserInteraction;
        private readonly Parameters _parameters = Game.Instance.Parameters;
    }
}
