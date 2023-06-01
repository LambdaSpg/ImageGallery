using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using ImageGalleryApp.Avalonia.ViewModel.Tabs;

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
}