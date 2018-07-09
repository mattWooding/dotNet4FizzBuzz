using System;
using NumberGameInterfaces;

namespace NumberGame
{
    public class NumberGameMain : IGame
    {
        
        private INumberProvider numberProvider;
        private INumberHandler numberHandler;
        private IOutputHandler outputHandler;
     
        public NumberGameMain(INumberProvider numberProvider, INumberHandler numberHandler, IOutputHandler outputHandler)
        {
            this.numberProvider = numberProvider;
            this.numberHandler = numberHandler;
            this.outputHandler = outputHandler;
        }

        public void Go()
        {
            while (numberProvider.Next())
            {
                outputHandler.Output(numberHandler.GetMessage(numberProvider.TheNumber));
            }
        }

    }
}
