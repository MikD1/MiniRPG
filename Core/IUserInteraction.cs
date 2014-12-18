using Core.GameActions;
using System;

namespace Core
{
    public interface IUserInteraction
    {
        string RequestPlayerName();
        void UpdatePlayerInfo(PlayerInfo info);
        GameActionType RequestUserAction();
        
        void PlayerWinFight();
        void PlayerLostFight();

        void PlayerDie();
        void NoMoney();
        void HealingNotRequired();

        void AutoActionMessage(string message);
    }
}
