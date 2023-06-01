using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using ImageGalleryApp.Avalonia.ViewModel;

namespace ImageGalleryApp.Avalonia.View;

public partial class HomeWindow : UserControl
{
    
    private HomeWindowViewModel ViewModel => (DataContext as HomeWindowViewModel)!;
    public HomeWindow()
    {
        InitializeComponent();
    }
    
    private void InitializeComponent() 
    {
         AvaloniaXamlLoader.Load(this);
    }

    private void TabControl_OnSelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        
    }
}