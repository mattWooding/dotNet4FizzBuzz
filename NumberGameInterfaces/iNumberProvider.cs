using System;

namespace NumberGameInterfaces
{
    public interface INumberProvider
    {
        bool Next();
        int TheNumber { get; }
        void Reset();
    }
}
