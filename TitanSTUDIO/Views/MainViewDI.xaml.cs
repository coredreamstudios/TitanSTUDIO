using SampleWpfLibrary;
using System.Windows;

namespace TitanSTUDIO.Views;

public partial class MainViewDI : Window
{
    private readonly IDataAccess dataAccess;
    private readonly IAbstractFactory<ChildView> factory;

    public MainViewDI(IDataAccess dataAccess, IAbstractFactory<ChildView> factory)
    {
        InitializeComponent();
        this.dataAccess = dataAccess;
        this.factory = factory;
    }

    public ChildView ChildView { get; }

    private void GetDataButton_Click(object sender, RoutedEventArgs e)
    {
        data.Text = dataAccess.GetData();
    }

    private void OpenChildView_Click(object sender, RoutedEventArgs e)
    {
        factory.Create().Show();
    }
}
