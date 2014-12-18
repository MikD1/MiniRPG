using System;

namespace Core
{
    public static class PlayerFactory
    {
        public static IPlayer CreatePlayer(string name)
        {
            return new SimplePlayer(name);
        }
    }
}
