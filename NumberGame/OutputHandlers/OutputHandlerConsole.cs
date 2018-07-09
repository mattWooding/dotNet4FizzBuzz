using System;
using NumberGameInterfaces;

namespace NumberGame.OutputHandlers
{
    public class OutputHandlerConsole : IOutputHandler
    {
        
        public void Output(string message)
        {
            Console.WriteLine(message);
        }

    }
}
