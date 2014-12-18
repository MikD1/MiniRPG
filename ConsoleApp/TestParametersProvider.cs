using Core;
using System;

namespace ConsoleApp
{
    internal sealed class TestParametersProvider : IParametersProvider
    {
        public Parameters GetParameters()
        {
            return new Parameters
            {
                PlayerStartHealth = 100,
                PlayerStartMaxHealth = 100,
                PlayerStartStrength = 1,
                PlayerStartMoney = 2,

                FightWinBaseRate = 40,
                FightWinStrengthRate = 5,
                FightWinMaxRate = 70,
                LostHealthWinFight = 10,
                LostHealthLoseFight = 40,
                FightWinPrize = 5,

                WeaponPrice = 10,
                WeaponMinBonus = 1,
                WeaponMaxBonus = 2,
                ClothesPrice = 10,
                ClothesMinBonus = 1,
                ClothesMaxBonus = 2,

                HealingRate = 10,
                HealingPrice = 3
            };
        }
    }
}
