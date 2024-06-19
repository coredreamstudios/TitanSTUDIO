using System.Windows;
using TitanSTUDIO.ViewModels;

namespace TitanSTUDIO.Views;

public partial class MainView : Window
{
    public MainView(MainViewModel mainViewModel)
    {
        InitializeComponent();
        DataContext = mainViewModel;
    }
}
