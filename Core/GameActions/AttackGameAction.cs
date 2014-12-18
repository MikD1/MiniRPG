using System;

namespace Core.GameActions
{
    internal sealed class AttackGameAction : IGameAction
    {
        public void Execute()
        {
            int winChance = Math.Min(_parameters.FightWinBaseRate + _player.Strength * _parameters.FightWinStrengthRate, _parameters.FightWinMaxRate);
            int fightResult = _random.Next(0, 100);

            int lostHealth = 0;
            if (winChance >= fightResult)
            {
                lostHealth = _parameters.LostHealthWinFight;
                _player.Money += _parameters.FightWinPrize;
                _userInteraction.PlayerWinFight();
            }
            else
            {
                lostHealth = _parameters.LostHealthLoseFight;
                _userInteraction.PlayerLostFight();
            }

            //_player.HP.Current -= (int)(_player.HP.Max * (lostHealth / 100.0));
            // Сделал вычитание HP в абсолютных единицах, а не в процентах
            // иначе повышение максимального HP не имеет смысла
            _player.HP.Current -= lostHealth;
        }

        private readonly IPlayer _player = Game.Instance.Player;
        private readonly IUserInteraction _userInteraction = Game.Instance.UserInteraction;
        private readonly Parameters _parameters = Game.Instance.Parameters;
        private readonly Random _random = new Random();
    }
}
