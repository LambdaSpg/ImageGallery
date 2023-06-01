using System;

namespace ImageGalleryApp.Avalonia.ViewModel;

public class MainWindowViewModel : ViewModelBase
{
    private string _text = "Hello World";

    public MainWindowViewModel()
    {
        ContentViewModel = new ContentViewModel();
    }
    
    public string Text
    {
        get => _text;
        set => RaiseAndSetIfChanged(ref _text, value);
    }

    public ContentViewModel ContentViewModel { get; }
}