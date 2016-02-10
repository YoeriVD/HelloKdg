using System.Windows.Input;
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
        public string MainText => "'sup from demo bruh!";

        public ICommand GoBack { get; } =
            new Command(() => App.NavigationPage.PopAsync());
    }
}