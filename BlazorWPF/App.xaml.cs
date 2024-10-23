using System.Windows;
using static BlazorWPF.Startup;

namespace BlazorWPF;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    public App()
    {
        Init();
        InitializeComponent();
    }
}
