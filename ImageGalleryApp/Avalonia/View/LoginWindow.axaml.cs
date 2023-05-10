using System;
using System.Drawing;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using ImageGalleryApp.Avalonia.ViewModel;
using Metsys.Bson;
using Color = System.Drawing.Color;

namespace ImageGalleryApp.Avalonia.View;

public partial class LoginWindow : UserControl
{
    private LoginViewModel ViewModel = new LoginViewModel();
    public LoginWindow()
    {
        InitializeComponent();
        
    }
    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}