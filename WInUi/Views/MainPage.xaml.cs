using Microsoft.UI.Xaml.Controls;

using WInUi.ViewModels;

namespace WInUi.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }
}
