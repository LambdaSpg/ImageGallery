using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.Json;
using ImageGalleryApp.Models;
using ImageGalleryApp.Modules;

namespace ImageGalleryApp.Avalonia.ViewModel;

public class EditPostWindowViewModel : ViewModelBase
{
    public int Id { get; set; }
    public Post Post { get; set; }
    public ContentViewModel ContentViewModel { get; set; }
    public ObservableCollection<string> Tags { get; set; }
    public string SelectedTag { get; set; }
    public Tag SelectedListTag { get; set; }
    
    public ObservableCollection<Tag> PostTags { get; set; }
    public EditPostWindowViewModel(int id, ContentViewModel contentViewModel)
    {
        Id = id;
        Post = ImageEngine.GetPost(Id);
        ContentViewModel = contentViewModel;
        
        Tags = new ObservableCollection<string>(ImageEngine.GetTags().Select(x => x.Name));
        PostTags = new ObservableCollection<Tag>(ImageEngine.GetPostTags().Where(x => x.PostId == Id).Select(x => x.Tag)
            .ToList());
        
        Console.WriteLine(JsonSerializer.Serialize(PostTags));
    }

    public void AddTag()
    {
        if(SelectedTag == null) return;
        var tba = ImageEngine.GetTags().First(x => x.Name == SelectedTag);
        if (!ImageEngine.GetPostTags().Any(x => x.PostId == Id && x.TagId == tba.Id))
        {
            PostTags.Add(tba);
            Console.WriteLine($"{tba.Id}, {Id}");
            ImageEngine.AddPostTag(new PostTags(Id, tba.Id));
        }
    }

    public void RemoveTag()
    {
        if (SelectedListTag == null) return;
        ImageEngine.RemovePostTag(ImageEngine.GetPostTags().First(x => x.Tag.Id == SelectedListTag.Id && x.PostId == Id));
        PostTags.Remove(SelectedListTag);
    }
}