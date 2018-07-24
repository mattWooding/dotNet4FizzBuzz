using System;
using TKMW.NumberGame.Interfaces;
using TKMW.NumberGame;
using TKMW.NumberGame.OutputHandlers;
using TKMW.NumberGame.NumberHandlers;
using TKMW.NumberGame.NumberProviders;

namespace TKMW.NumberGame
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
