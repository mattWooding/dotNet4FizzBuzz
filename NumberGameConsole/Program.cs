using System;
using TKMW.NumberGame.Interfaces;

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
