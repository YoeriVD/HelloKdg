using System.Windows.Input;
using HelloKdg.Navigation;
using Xamarin.Forms;

namespace HelloKdg.NavigateDemo
{
    public interface IDemoViewModel
    {
        string MainText { get; }
        ICommand GoBack { get; }
    }

    internal class DemoViewModel : IDemoViewModel
    {
        private readonly IAppNavigation _navigation;

        public DemoViewModel(IAppNavigation navigation)
        {
            _navigation = navigation;
        }

        public string MainText => "'sup from demo bruh!";

        public ICommand GoBack => new Command(() => _navigation.NavigateBack());
    }
}