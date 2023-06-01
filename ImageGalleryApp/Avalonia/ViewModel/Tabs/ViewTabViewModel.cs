using System;
using System.Collections.ObjectModel;
using Avalonia.Controls;
using Avalonia.Layout;
using ImageGalleryApp.Models;

namespace ImageGalleryApp.Avalonia.ViewModel.Tabs;

public class ViewTabViewModel : ViewModelBase
{
    public ObservableCollection<Post> Posts { get; } = new()
    {
        new()
        {
            Title = "Heo",
            Path = "/Assets/account.png"
        },
        new()
        {
            Title = "Heo",
            Path = "/Assets/account.svg"
        },
        new()
        {
            Title = "Heo",
            Path = "/Assets/account.png"
        },
        new()
        {
            Title = "Heo",
            Path = "/Assets/account.png"
        },
        new()
        {
            Title = "Heo",
            Path = "/Assets/account.png"
        },
        new()
        {
            Title = "Heo",
            Path = "/Assets/account.png"
        },
        new()
        {
            Title = "Heo",
            Path = "/Assets/account.png"
        },
    };

    public ViewTabViewModel()
    {
        Console.WriteLine("Initialized ViewTabViewModel");
    }
}