using System;

namespace TKMW.NumberGame.Interfaces
{
    public interface INumberProvider
    {
        bool Next();
        int TheNumber { get; }
        void Reset();
    }
}
