using System;
using Avalonia.Media;

namespace ImageGalleryApp.Avalonia.ViewModel;

public class LoginViewModel : ViewModelBase
{
    //private Brush brush = new SolidColorBrush(Color.FromRgb(1, 230, 119));
    private Brush brush = new SolidColorBrush(0x2200ff);
    
    public Brush Brush
    {
        get => brush;
        set => RaiseAndSetIfChanged(ref brush, value);
    }
}