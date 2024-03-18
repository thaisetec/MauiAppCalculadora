namespace MauiAppCalculadora
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

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

        private void maismenos_Clicked(object sender, EventArgs e)
        {

        }

        private void dividir_Clicked(object sender, EventArgs e)
        {

        }

        private void num7_Clicked(object sender, EventArgs e)
        {

        }

        private void num5_Clicked(object sender, EventArgs e)
        {

        }

        private void num6_Clicked(object sender, EventArgs e)
        {

        }
    }

}
