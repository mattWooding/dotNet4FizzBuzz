using System;
using TKMW.NumberGame.Interfaces;

namespace TKMW.NumberGame.OutputHandlers
{
    public class OutputHandlerConsole : IOutputHandler
    {
        
        public void Output(string message)
        {
            Console.WriteLine(message);
        }

    }
}
