using System;
using Autofac;
using HelloKdg.Navigation;
using Xamarin.Forms;

namespace HelloKdg.IoC
{
    internal class Technical : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder
                .RegisterType<AppNavigation>()
                .As<IAppNavigation>()
                .WithParameter(new TypedParameter(typeof (Lazy<NavigationPage>),
                    new Lazy<NavigationPage>(() => (NavigationPage) Application.Current.MainPage)));
        }
    }
}