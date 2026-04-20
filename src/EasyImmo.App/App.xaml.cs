using EasyImmo.App.Views;

namespace EasyImmo.App
{
    public partial class App : Application
    {
        public TitlebarWindow OurWindow { get; }

        public App(TitlebarWindow ourWindow)
        {
            InitializeComponent();
            OurWindow = ourWindow;
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {

            OurWindow.Page = new AppShell();

            OurWindow.Width = 1366;
            OurWindow.Height = 768;

            OurWindow.MinimumWidth = 1366;
            OurWindow.MinimumHeight = 768;

            return OurWindow;
        }
    }
}