using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CantExecute
{
    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _buttonText = "Click me";

        private int count = 0;


        [RelayCommand]
        public async Task OnCounterClicked()
        {
            count++;

            if (count == 1)
                ButtonText = $"Clicked {count} time";
            else
                ButtonText = $"Clicked {count} times";

            // Simulate doing some work...
            await Task.Delay( 250 );

            SemanticScreenReader.Announce(ButtonText);
        }
    }
}
