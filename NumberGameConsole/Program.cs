using System;
using NumberGameInterfaces;
using NumberGame;
using NumberGame.OutputHandlers;
using NumberGame.NumberHandlers;
using NumberGame.NumberProviders;

namespace ActiveNavConsole
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            IGame game = DependencyFactory.Resolve<IGame>();
            game.Go();
        }
    }
}
