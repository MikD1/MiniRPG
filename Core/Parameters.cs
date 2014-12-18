using System;

namespace Core
{
    public struct Parameters
    {
        // Start parameters
        public int PlayerStartHealth { get; set; }
        public int PlayerStartMaxHealth { get; set; }
        public int PlayerStartStrength { get; set; }
        public int PlayerStartMoney { get; set; }

        // Fight parameters
        public int FightWinBaseRate { get; set; }
        public int FightWinStrengthRate { get; set; }
        public int FightWinMaxRate { get; set; }
        public int LostHealthWinFight { get; set; }
        public int LostHealthLoseFight { get; set; }
        public int FightWinPrize { get; set; }

        // Trading
        public int WeaponPrice { get; set; }
        public int WeaponMinBonus { get; set; }
        public int WeaponMaxBonus { get; set; }
        public int ClothesPrice { get; set; }
        public int ClothesMinBonus { get; set; }
        public int ClothesMaxBonus { get; set; }

        // Healing
        public int HealingRate { get; set; }
        public int HealingPrice { get; set; }
    }
}
