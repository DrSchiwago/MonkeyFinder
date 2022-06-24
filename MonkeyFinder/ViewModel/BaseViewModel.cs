using CommunityToolkit.Mvvm.ComponentModel;

namespace MonkeyFinder.ViewModel
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        [AlsoNotifyChangeFor(nameof(IsNotBusy))]
        bool isBusy;

        [ObservableProperty]
        string title;

        public bool IsNotBusy => !IsBusy;


        // Ohne NuGet CommunityToolkit.Mvvm
        //public bool IsBusy {
        //    get => isBusy;
        //    set
        //    {
        //        if (isBusy != value)
        //            return;
        //        isBusy = value;
        //        OnPropertyChanged();

        //        OnPropertyChanged(nameof(IsNotBusy));
        //    } 
        //}

        //public bool IsNotBusy => !IsBusy;

        //public string Title
        //{
        //    get => title;
        //    set
        //    {
        //        if (title != value)
        //            return;
        //        title = value;
        //        OnPropertyChanged();
        //    }
        //}

        //public event PropertyChangedEventHandler PropertyChanged;

        //public void OnPropertyChanged([CallerMemberName] string name = null) =>
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
