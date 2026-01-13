namespace EasyImmo
{
    public partial class App : Application
    {
        public TitlebarWindows OurWindow { get; }
        public App(TitlebarWindows ourWindow)
        {
            InitializeComponent();
            OurWindow = ourWindow;
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            OurWindow.Page = new AppShell();
            return OurWindow;
        }
    }
}