using CommunityToolkit.Mvvm.ComponentModel;

namespace TitanSTUDIO.ViewModels
{
    public class MainViewModel : ObservableObject
    { 

        private string _version = "1.00";
        public string Version
        {
            get => _version;
            set => SetProperty(ref _version, value);
        }

    }
}
