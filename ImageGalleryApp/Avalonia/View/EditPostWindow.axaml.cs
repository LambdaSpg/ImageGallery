using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using ImageGalleryApp.Avalonia.ViewModel;

namespace ImageGalleryApp.Avalonia.View;

public partial class EditPostWindow : UserControl
{
    public EditPostWindowViewModel ViewModel => (DataContext as EditPostWindowViewModel)!;
    public EditPostWindow()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    private void Exit(object? sender, RoutedEventArgs e)
    {
        ViewModel.ContentViewModel.Content = new HomeWindow()
        {
            DataContext = new HomeWindowViewModel(ViewModel.ContentViewModel)
        };
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