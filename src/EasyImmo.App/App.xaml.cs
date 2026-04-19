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

        protected override Window CreateWindow(IActivationState activationState)
        {

            OurWindow.Page = new AppShell();
            return OurWindow;
        }
    }
}