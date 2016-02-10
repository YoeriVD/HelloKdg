using System.Reflection;
using Autofac;

namespace HelloKdg.IoC
{
    internal class AppContainer
    {
        public IContainer CreateContainer()
        {
            var builder = new ContainerBuilder();
            // Registers all modules
            builder.RegisterAssemblyModules(GetType().GetTypeInfo().Assembly);
            return builder.Build();
        }
    }
}