using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using ImageGalleryApp.Avalonia.ViewModel;

namespace ImageGalleryApp;

public partial class App : Application
{
    public static Window window { get; set; }
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow()
            {
                DataContext = new MainWindowViewModel()
            };
            window = desktop.MainWindow!;
        }

        base.OnFrameworkInitializationCompleted();
    }
}