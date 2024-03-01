using BankingLocalMaui.Services;

namespace BankingLocalMaui
{
    public partial class MainPage : ContentPage
    {
        int count = 10;
        private BankingLocalDatabase _database; // using the member variable to test 

        public MainPage()
        {
            InitializeComponent();
            
            _database = new BankingLocalDatabase(); // method to call it 
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
    }

}
