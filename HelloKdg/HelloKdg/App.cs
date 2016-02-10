using System;
using Autofac;
using HelloKdg.IoC;
using HelloKdg.Main;
using Xamarin.Forms;

namespace HelloKdg
{
    public class App : Application
    {
        private static readonly Lazy<IContainer> LazyContainer =
            new Lazy<IContainer>(() => new AppContainer().CreateContainer());

        internal static NavigationPage NavigationPage { get; private set; }

        public static IContainer Container => LazyContainer.Value;
        public App()
        {
            // The root page of your application
            NavigationPage = new NavigationPage(Container.Resolve<MainPage>());
            MainPage = NavigationPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
