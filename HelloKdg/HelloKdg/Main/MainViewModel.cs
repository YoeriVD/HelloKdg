namespace HelloKdg.Main
{
    public interface IMainViewModel
    {
        string MainText { get; }
    }

    class MainViewModel : IMainViewModel
    {
        public string MainText => "sup brah!";
    }
}
