using SampleWpfLibrary;
using System.Windows;

namespace TitanSTUDIO.Views;

public partial class ChildView : Window
{
    private readonly IDataAccess dataAccess;

    public ChildView(IDataAccess dataAccess)
    {
        InitializeComponent();
        this.dataAccess = dataAccess;
        dataAccessInfo.Text = dataAccess.GetData();
    }
}
