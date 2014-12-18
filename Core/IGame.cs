using System;

namespace Core
{
    public interface IGame
    {
        void Start(Parameters parameters, IUserInteraction userInteraction);
    }
}
