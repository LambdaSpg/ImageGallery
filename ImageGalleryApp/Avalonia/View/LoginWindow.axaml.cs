using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ImageGalleryApp.Avalonia.View;

public partial class LoginWindow : UserControl
{
    public LoginWindow()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}