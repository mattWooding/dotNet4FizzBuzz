using System;
using Unity;
using Microsoft.Practices.Unity;
using NumberGame;
using NumberGame.OutputHandlers;
using NumberGame.NumberProviders;
using NumberGame.NumberHandlers;
using NumberGameInterfaces;
using Unity.Injection;

namespace ActiveNavConsole
{
    public class DependencyFactory
    {
        public static IUnityContainer Container { get; set; }

        static DependencyFactory()
        {
            Container = new UnityContainer();
            // These could be stored in an app.config file
            Container.RegisterType<IGame, NumberGameMain>();
            Container.RegisterType<IOutputHandler, OutputHandlerConsole>();
            Container.RegisterType<INumberProvider, NumberProviderSequential>(new InjectionConstructor(1, 100, 1, NumberProviderSequential.countDirections.up));
            Container.RegisterType<INumberHandler, NumberHandler>();
        }

        public static T Resolve<T>()
        {
            T ret = default(T);
            if (Container.IsRegistered(typeof(T)))
            {
                ret = Container.Resolve<T>();
            }
            return ret;
        }

    }
}
