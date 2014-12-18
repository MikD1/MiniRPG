using System;

namespace Core
{
    public sealed class Health
    {
        public Health(int value)
        {
            Max = value;
            Current = value;
        }

        public int Max
        {
            get
            {
                return _max;
            }
            set
            {
                _max = value > 0 ? value : 0;
                if (_current > _max)
                {
                    _current = _max;
                }
            }
        }
        public int Current
        {
            get
            {
                return _current;
            }
            set
            {
                if (value < 0)
                {
                    _current = 0;
                }
                else if (value > _max)
                {
                    _current = _max;
                }
                else
                {
                    _current = value;
                }
            }
        }
        public bool IsFull
        {
            get
            {
                return Current == Max;
            }
        }

        private int _max = 0;
        private int _current = 0;
    }
}
