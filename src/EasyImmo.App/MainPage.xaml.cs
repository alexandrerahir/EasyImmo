using EasyImmo.Business.Services;

namespace EasyImmo.App
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            var agent = AuthService.Instance.CurrentAgent;

            if (agent != null)
            {
                AgentNameLabel.Text = $"Bienvenue, {agent.FirstNameAgent} {agent.LastNameAgent}";
            }
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}
