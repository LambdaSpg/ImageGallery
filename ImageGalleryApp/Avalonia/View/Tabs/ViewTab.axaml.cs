using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using ImageGalleryApp.Avalonia.ViewModel.Tabs;
using ImageGalleryApp.Models;

namespace ImageGalleryApp.Avalonia.View.Tabs;

public partial class ViewTab : UserControl
{
    
    private ViewTabViewModel ViewModel => (DataContext as ViewTabViewModel)!;

    public ViewTab()
    {
        InitializeComponent();
    }
    
    private void InitializeComponent() 
    { 
        AvaloniaXamlLoader.Load(this);
    }
    
    private void InspectImage(object? sender, RoutedEventArgs e)
    {
        var data = (sender as Button)!.DataContext as Post;
        ViewModel.InspectImage(data!.Id);
    }
}