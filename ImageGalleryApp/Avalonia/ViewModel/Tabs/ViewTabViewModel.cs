using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.Json;
using Avalonia.Controls;
using Avalonia.Layout;
using ImageGalleryApp.Avalonia.View;
using ImageGalleryApp.Models;
using ImageGalleryApp.Modules;

namespace ImageGalleryApp.Avalonia.ViewModel.Tabs;

public class ViewTabViewModel : ViewModelBase
{
    public ObservableCollection<Post> Posts { get; set; }
    public ContentViewModel ContentViewModel;
    public bool DeleteMode { get; set; }

    public ViewTabViewModel(ContentViewModel contentViewModel)
    {
        this.ContentViewModel = contentViewModel;
        Console.WriteLine("Initialized ViewTabViewModel");
        Posts = new ObservableCollection<Post>(ImageEngine.GetPosts(50));
    }

    public void InspectImage(int id)
    {
        if (DeleteMode)
        {
            var post = Posts.First(x => x.Id == id);
            Posts.Remove(post);
            ImageEngine.RemovePost(post);
            return;
        }
        ContentViewModel.Content = new EditPostWindow()
        {
            DataContext = new EditPostWindowViewModel(id, ContentViewModel)
        };
    }
}