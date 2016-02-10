using Autofac;
using HelloKdg.Navigation;

namespace HelloKdg.IoC
{
    internal class Technical : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder
                .RegisterType<Navigation.AppNavigation>()
                .As<IAppNavigation>();
        }
    }
}