using CommunityToolkit.Mvvm.ComponentModel;

namespace TitanSTUDIO.ViewModels;

public class SettingsViewModel : ObservableObject
{
    private string _setting = "Some Setting String";
    public string Setting
    {
        get => _setting;
        set => SetProperty(ref _setting, value);
    }
}
