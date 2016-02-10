using System;
using System.Reflection;
using Autofac;

namespace HelloKdg.IoC
{
    internal class AppContainer
    {
        private static readonly Lazy<IContainer> LazyContainer =
            new Lazy<IContainer>(() => new AppContainer().CreateContainer());

        public static IContainer Container => LazyContainer.Value;

        private IContainer CreateContainer()
        {
            var builder = new ContainerBuilder();
            // Registers all modules
            builder.RegisterAssemblyModules(GetType().GetTypeInfo().Assembly);
            return builder.Build();
        }
    }
}