using System.Runtime.CompilerServices;

namespace MauiApp1
{

    public partial class MainPage : ContentPage
    {
        int count = 0;
        //tipo nomedavariavel = 0;
        string nome = "";

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void OnHelloClicked(object sender, EventArgs e)
        {
            nome = NameEntry.Text;
            //interpolação
            GreetingLabel.Text = $"Hello, {nome}";

            SemanticScreenReader.Announce(GreetingLabel.Text);
        }

    }

}
