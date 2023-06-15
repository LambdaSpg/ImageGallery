using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using ImageGalleryApp.Avalonia.ViewModel.Tabs;

namespace ImageGalleryApp.Avalonia.View.Tabs;

public partial class TagTab : UserControl
{
    public TagTabViewModel ViewModel => (DataContext as TagTabViewModel)!;
    public TagTab()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    private void AddTag(object? sender, RoutedEventArgs e)
    {
        ViewModel.AddTag();
    }

    private void RemoveTag(object? sender, RoutedEventArgs e)
    {
        ViewModel.RemoveTag();
    }
}