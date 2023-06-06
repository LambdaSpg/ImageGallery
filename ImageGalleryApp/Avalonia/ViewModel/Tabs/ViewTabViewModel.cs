using System;
using System.Collections.ObjectModel;
using Avalonia.Controls;
using Avalonia.Layout;
using ImageGalleryApp.Models;
using ImageGalleryApp.Modules;

namespace ImageGalleryApp.Avalonia.ViewModel.Tabs;

public class ViewTabViewModel : ViewModelBase
{
    //public ObservableCollection<Post> Posts { get; } = (ObservableCollection<Post>)ImageEngine.GetPosts(50);
    public ObservableCollection<Post> Posts { get; } = new ObservableCollection<Post>()
    {
        new Post()
        {
            Path = "/Assets/account.png"
        },
        new Post()
        {
            Path = "/Assets/account.png"
        },
        new Post()
        {
            Path = "/Assets/account.png"
        },
        new Post()
        {
            Path = "/Assets/account.png"
        },
        new Post()
        {
            Path = "/Assets/account.png"
        },
        new Post()
        {
            Path = "/Assets/account.png"
        },
        new Post()
        {
            Path = "/Assets/account.png"
        },
        new Post()
        {
            Path = "/Assets/account.png"
        },
        new Post()
        {
            Path = "/Assets/account.png"
        },
        new Post()
        {
            Path = "/Assets/account.png"
        },
    };

    public ViewTabViewModel()
    {
        Console.WriteLine("Initialized ViewTabViewModel");
    }
}