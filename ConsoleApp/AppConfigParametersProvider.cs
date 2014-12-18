using Core;
using System;
using System.Collections.Specialized;
using System.Configuration;

namespace ConsoleApp
{
    internal sealed class AppConfigParametersProvider : IParametersProvider
    {
        public Parameters GetParameters()
        {
            NameValueCollection appSettings = ConfigurationManager.AppSettings;

            return new Parameters()
            {
                PlayerStartHealth = int.Parse(appSettings["PlayerStartHealth"]),
                PlayerStartMaxHealth = int.Parse(appSettings["PlayerStartMaxHealth"]),
                PlayerStartStrength = int.Parse(appSettings["PlayerStartStrength"]),
                PlayerStartMoney = int.Parse(appSettings["PlayerStartMoney"]),

                FightWinBaseRate = int.Parse(appSettings["FightWinBaseRate"]),
                FightWinStrengthRate = int.Parse(appSettings["FightWinStrengthRate"]),
                FightWinMaxRate = int.Parse(appSettings["FightWinMaxRate"]),
                LostHealthWinFight = int.Parse(appSettings["LostHealthWinFight"]),
                LostHealthLoseFight = int.Parse(appSettings["LostHealthLoseFight"]),
                FightWinPrize = int.Parse(appSettings["FightWinPrize"]),

                WeaponPrice = int.Parse(appSettings["WeaponPrice"]),
                WeaponMinBonus = int.Parse(appSettings["WeaponMinBonus"]),
                WeaponMaxBonus = int.Parse(appSettings["WeaponMaxBonus"]),
                ClothesPrice = int.Parse(appSettings["ClothesPrice"]),
                ClothesMinBonus = int.Parse(appSettings["ClothesMinBonus"]),
                ClothesMaxBonus = int.Parse(appSettings["ClothesMaxBonus"]),

                HealingRate = int.Parse(appSettings["HealingRate"]),
                HealingPrice = int.Parse(appSettings["HealingPrice"])
            };
        }
    }
}
