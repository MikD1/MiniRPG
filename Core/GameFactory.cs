using System;

namespace Core
{
    public static class GameFactory
    {
        public static IGame CreateGame()
        {
            return new Game();
        }
    }
}
