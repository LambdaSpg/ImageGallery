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
}