using Core.GameActions;
using System;

namespace Core
{
    internal sealed class Game : IGame
    {
        public void Start(Parameters parameters, IUserInteraction userInteraction)
        {
            _parameters = parameters;
            _userInteraction = userInteraction;
            _instance = this;

            Loop();
        }

        public static Game Instance
        {
            get
            {
                return _instance;
            }
        }

        public Parameters Parameters
        {
            get
            {
                return _parameters;
            }
        }
        public IPlayer Player
        {
            get
            {
                return _player;
            }
        }
        public IUserInteraction UserInteraction
        {
            get
            {
                return _userInteraction;
            }
        }

        private void Loop()
        {
            while (true)
            {
                string playerName = _userInteraction.RequestPlayerName();
                _player = PlayerFactory.CreatePlayer(playerName);

                while (true)
                {
                    _userInteraction.UpdatePlayerInfo(_player.GetInfo());

                    GameActionType actionType = _userInteraction.RequestUserAction();
                    IGameAction gameAction = GameActionsFactory.CreateGameAction(actionType);
                    gameAction.Execute();

                    if (_player.HP.Current == 0)
                    {
                        _userInteraction.PlayerDie();
                        break;
                    }
                }
            }
        }

        private IPlayer _player;
        private Parameters _parameters;
        private IUserInteraction _userInteraction;
        private static Game _instance = null;
    }
}
