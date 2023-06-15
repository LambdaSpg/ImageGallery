using System;
using Avalonia.Media;
using ImageGalleryApp.Avalonia.View;

namespace ImageGalleryApp.Avalonia.ViewModel;

public class LoginViewModel : ViewModelBase
{
    private ContentViewModel contentView;

    public LoginViewModel(ContentViewModel contentView)
    {
        this.contentView = contentView;
    }
    
    public void OnClickCommand()
    {
        Console.WriteLine("Working");
        contentView.Content = new HomeWindow()
        {
            DataContext = new HomeWindowViewModel(contentView)
        };
    }
}