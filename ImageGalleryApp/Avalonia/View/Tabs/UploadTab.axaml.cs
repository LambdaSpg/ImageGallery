using System;
using System.Collections.ObjectModel;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using ImageGalleryApp.Avalonia.ViewModel.Tabs;
using ImageGalleryApp.Models;

namespace ImageGalleryApp.Avalonia.View.Tabs;

public partial class UploadTab : UserControl
{
    private UploadTabViewModel ViewModel => (DataContext as UploadTabViewModel)!;

    public UploadTab()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}