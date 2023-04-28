using Avalonia.Controls;
using Avalonia.Interactivity;
using ImageGalleryApp.Avalonia.ViewModel;

namespace ImageGalleryApp;

public partial class MainWindow : Window
{

    private MainWindowViewModel ViewModel => (DataContext as MainWindowViewModel)!;
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        ViewModel.Text = "It didnt work!";
    }
}