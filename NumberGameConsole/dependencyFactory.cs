using Unity;
using TKMW.NumberGame.OutputHandlers;
using TKMW.NumberGame.NumberProviders;
using TKMW.NumberGame.NumberHandlers;
using TKMW.NumberGame.Interfaces;
using Unity.Injection;

namespace TKMW.NumberGame
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
            //Container.RegisterType<INumberProvider, NumberProviderSequential>(new InjectionConstructor(1, 100, 1, NumberProviderSequential.countDirections.up));
            Container.RegisterType<INumberProvider, NumberProviderRandom>();
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
