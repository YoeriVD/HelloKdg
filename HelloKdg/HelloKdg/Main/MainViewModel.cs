using System.Windows.Input;
using Autofac;
using HelloKdg.NavigateDemo;
using Xamarin.Forms;

namespace HelloKdg.Main
{
    public interface IMainViewModel
    {
        string MainText { get; }
        ICommand NavigateToDemo { get; }
    }

    internal class MainViewModel : IMainViewModel
    {
        public string MainText => "sup brah!";

        public ICommand NavigateToDemo { get; } =
            new Command(() => App.NavigationPage.PushAsync(App.Container.Resolve<DemoPage>()));
    }
}