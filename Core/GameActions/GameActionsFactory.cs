using System;

namespace Core.GameActions
{
    public static class GameActionsFactory
    {
        public static IGameAction CreateGameAction(GameActionType type)
        {
            switch (type)
            {
                case GameActionType.Attack:
                    return new AttackGameAction();

                case GameActionType.BuyClothes:
                    return new BuyClothesGameAction();

                case GameActionType.BuyWeapon:
                    return new BuyWeaponGameAction();

                case GameActionType.Healing:
                    return new HealingGameAction();

                case GameActionType.Auto:
                    return new AutoGameAction();

                default:
                    throw new Exception("Unexpected game action type");
            }
        }
    }
}
