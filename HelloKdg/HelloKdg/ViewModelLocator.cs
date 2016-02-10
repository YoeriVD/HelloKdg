using Autofac;
using HelloKdg.IoC;
using HelloKdg.Main;

namespace HelloKdg
{
    internal static class ViewModelLocator
    {
        internal static IMainViewModel MainViewModel => Resolve<IMainViewModel>();

        private static T Resolve<T>()
        {
            using (var scope = AppContainer.Container.BeginLifetimeScope())
            {
                return scope.Resolve<T>();
            }
        }
    }
}