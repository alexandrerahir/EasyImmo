using EasyImmo.App.Views;

namespace EasyImmo.App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
        }
    }
}