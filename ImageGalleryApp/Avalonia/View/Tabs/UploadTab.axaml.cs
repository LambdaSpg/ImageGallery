using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ImageGalleryApp.Avalonia.View.Tabs;

public partial class UploadTab : UserControl
{
    public UploadTab()
    {
        InitializeComponent(); 
        Console.WriteLine("Loading UploadTab");
    }
}