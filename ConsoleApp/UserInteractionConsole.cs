using Core;
using Core.GameActions;
using Core.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    internal sealed class UserInteractionConsole : IUserInteraction
    {
        public string RequestPlayerName()
        {
            Console.Write("\nEnter player name: ");
            return Console.ReadLine();
        }
        public void UpdatePlayerInfo(PlayerInfo info)
        {
            Console.WriteLine("\n===========================================");
            Console.WriteLine(string.Format("{0} info", info.Name));
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine(string.Format("HP: {0}\\{1}\nStrength: {2}\nMoney: {3}",
                info.HP, info.MaxHP, info.Strength, info.Money));
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Inventory:");
            Console.WriteLine("-------------------------------------------");

            List<IClothes> clothesItems = info.Inventory.Where(i => i.Type == InventoryType.Clothes).Cast<IClothes>().ToList();
            Console.WriteLine(string.Format("Clothes ({0})", clothesItems.Count));
            foreach (IClothes item in clothesItems)
            {
                Console.WriteLine(string.Format("{0} ({1})", item.Name, item.Protection));
            }

            List<IWeapon> weaponItems = info.Inventory.Where(i => i.Type == InventoryType.Weapon).Cast<IWeapon>().ToList();
            Console.WriteLine(string.Format("Weapons ({0})", weaponItems.Count));
            foreach (IWeapon item in weaponItems)
            {
                Console.WriteLine(string.Format("{0} ({1})", item.Name, item.Damage));
            }

            Console.WriteLine("===========================================");
        }

        public GameActionType RequestUserAction()
        {
            while (true)
            {
                Console.WriteLine("\n(W) - attack; (A) - buy weapon; (D) - buy clothes; (S) - healing; (E) - auto");
                Console.Write("Select action: ");
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                switch (keyInfo.Key)
                {
                    case ConsoleKey.W:
                        return GameActionType.Attack;

                    case ConsoleKey.A:
                        return GameActionType.BuyWeapon;

                    case ConsoleKey.D:
                        return GameActionType.BuyClothes;

                    case ConsoleKey.S:
                        return GameActionType.Healing;

                    case ConsoleKey.E:
                        return GameActionType.Auto;

                    default:
                        Console.WriteLine("\nError.");
                        break;
                }

                //Console.Clear();
            }
        }

        public void PlayerWinFight()
        {
            Console.WriteLine("\n\nYou win! =)");
        }
        public void PlayerLostFight()
        {
            Console.WriteLine("\n\nYou lose! =(");
        }

        public void PlayerDie()
        {
            Console.WriteLine("\nRIP");
        }
        public void NoMoney()
        {
            Console.WriteLine("\n\nNo money");
        }
        public void HealingNotRequired()
        {
            Console.WriteLine("\n\nHealing not required");
        }

        public void AutoActionMessage(string message)
        {
            Console.WriteLine("\n" + message);
        }
    }
}
