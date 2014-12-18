using Core;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IParametersProvider parametersProvider = ParametersProviderFactory.GetAppConfigParametersProvider();
            IUserInteraction userInteraction = new UserInteractionConsole();

            IGame game = GameFactory.CreateGame();
            game.Start(parametersProvider.GetParameters(), userInteraction);
        }
    }
}
