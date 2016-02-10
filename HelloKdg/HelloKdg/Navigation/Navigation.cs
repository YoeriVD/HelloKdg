using System;
using System.Threading.Tasks;
using Autofac;
using Xamarin.Forms;

namespace HelloKdg.Navigation
{
    internal interface IAppNavigation
    {
        Task NavigateTo<T>() where T : Page;
        Task NavigateBack();
        Task NavigateToRoot();
    }

    internal class AppNavigation : IAppNavigation
    {
        private readonly ILifetimeScope _container;
        private readonly Func<NavigationPage> _navigationPage;

        public AppNavigation(ILifetimeScope container)
        {
            _container = container;
            //todo: inject this ?
            _navigationPage = () => Application.Current.MainPage as NavigationPage;
        }

        public Task NavigateTo<T>() where T : Page
        {
            return _navigationPage().PushAsync(_container.Resolve<T>());
        }

        public Task NavigateBack()
        {
            return _navigationPage().PopAsync();
        }

        public Task NavigateToRoot()
        {
            return _navigationPage().PopToRootAsync();
        }
    }
}