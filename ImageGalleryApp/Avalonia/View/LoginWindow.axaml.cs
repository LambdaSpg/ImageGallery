using System;
using System.Drawing;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using ImageGalleryApp.Avalonia.ViewModel;
using Metsys.Bson;
using Color = System.Drawing.Color;

namespace ImageGalleryApp.Avalonia.View;

public partial class LoginWindow : UserControl
{
    private LoginViewModel viewModel;
    
    public LoginWindow(ContentViewModel contentView)
    {
        viewModel = new LoginViewModel(contentView);
        InitializeComponent();
    }
    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        viewModel.OnClickCommand();
    }
}