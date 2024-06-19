using System.Windows.Controls;
using TitanSTUDIO.ViewModels;

namespace TitanSTUDIO.UserControls;

public partial class SettingsUserControl : UserControl
{
    public SettingsUserControl(SettingsViewModel settingsViewModel)
    {
        InitializeComponent();
        DataContext = settingsViewModel;
    }
}
