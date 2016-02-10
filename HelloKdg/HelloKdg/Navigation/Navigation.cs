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
        private readonly IComponentContext _container;
        private readonly Lazy<NavigationPage> _navigationPage;
        private NavigationPage NavigationPage => _navigationPage.Value;

        public AppNavigation(IComponentContext container, Lazy<NavigationPage> navigationPage)
        {
            _container = container;
            _navigationPage = navigationPage;
        }

        public Task NavigateTo<T>() where T : Page
        {
            return NavigationPage.PushAsync(_container.Resolve<T>());
        }

        public Task NavigateBack()
        {
            return NavigationPage.PopAsync();
        }

        public Task NavigateToRoot()
        {
            return NavigationPage.PopToRootAsync();
        }
    }
}