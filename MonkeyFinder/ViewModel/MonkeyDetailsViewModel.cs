﻿namespace MonkeyFinder.ViewModel
{
    [QueryProperty(nameof(Monkey), "Monkey")]
    public partial  class MonkeyDetailsViewModel : BaseViewModel
    {
        IMap map;
        public MonkeyDetailsViewModel(IMap map)
        {
            this.map = map;
        }

        [ObservableProperty]
        Monkey monkey;

        [ICommand]
        async Task OpenMap()
        {
            try
            {
                await map.OpenAsync(Monkey.Latitude, Monkey.Longitude, new MapLaunchOptions
                {
                    Name = Monkey.Name,
                    NavigationMode = NavigationMode.None
                });
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Unable to to launch maps: {ex.Message}");
                await Application.Current.MainPage.DisplayAlert("Error, no Maps app!", ex.Message, "OK");
            }
        }

    }
}
