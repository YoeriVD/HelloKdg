using Autofac;
using HelloKdg.IoC;
using HelloKdg.Main;
using Xamarin.Forms;

namespace HelloKdg
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            MainPage = new NavigationPage(AppContainer.Container.Resolve<MainPage>());
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
