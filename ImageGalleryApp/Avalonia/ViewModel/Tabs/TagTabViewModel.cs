using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.Json;
using ImageGalleryApp.Models;
using ImageGalleryApp.Modules;

namespace ImageGalleryApp.Avalonia.ViewModel.Tabs;

public class TagTabViewModel : ViewModelBase
{
    public ObservableCollection<Tag> Tags { get; set; }
    public Tag SelectedListTag { get; set; }
    public string TagName { get; set; }

    public TagTabViewModel()
    {
        UpdateTags();
    }

    private void UpdateTags()
    {
        Tags = new(ImageEngine.GetTags());
    }
    public void AddTag()
    {
        Tag t = new Tag(TagName, null, null);
        if (ImageEngine.GetTags().All(x => x.Name != t.Name))
        {
            ImageEngine.AddTag(t);
            Tags.Add(t);
        }
    }

    public void RemoveTag()
    {
        if (ImageEngine.GetTags().Any(x => x.Name == SelectedListTag.Name))
        {
            ImageEngine.RemoveTag(SelectedListTag);
            Tags.Remove(SelectedListTag);
        }
    }
}