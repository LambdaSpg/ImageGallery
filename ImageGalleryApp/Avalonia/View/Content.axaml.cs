using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ImageGalleryApp.Avalonia.View;

public partial class Content : UserControl
{
    public Content()
    {
        InitializeComponent();
    }

   private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}