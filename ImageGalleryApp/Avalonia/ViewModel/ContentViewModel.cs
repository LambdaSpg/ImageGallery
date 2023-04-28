using Avalonia.Layout;
using ImageGalleryApp.Avalonia.View;

namespace ImageGalleryApp.Avalonia.ViewModel;

public class ContentViewModel : ViewModelBase
{
    private Layoutable _content;

    public ContentViewModel()
    {
        _content = new LoginWindow();
    }

    public Layoutable Content
    {
        get => _content;
        set => RaiseAndSetIfChanged(ref _content, value);
    }
}