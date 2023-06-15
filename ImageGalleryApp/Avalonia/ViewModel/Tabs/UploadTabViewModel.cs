using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.Json;
using Avalonia;
using Avalonia.Dialogs;
using Avalonia.Platform.Storage;
using DynamicData.Binding;
using ImageGalleryApp.Models;
using ImageGalleryApp.Modules;

namespace ImageGalleryApp.Avalonia.ViewModel.Tabs;

public class UploadTabViewModel : ViewModelBase
{
    public ObservableCollection<string> PoolList { get; set; }
    public ObservableCollection<string> UserList { get; set; }

    public string TitleText { get; set; }
    public string PathText { get; set; }
    public string PoolName { get; set; }
    public string UserName { get; }


    public UploadTabViewModel()
    {
        UpdateContents();
        Console.WriteLine(JsonSerializer.Serialize(PoolList));
    }


    public void UpdateContents()
    {
        UserList = new(ImageEngine.GetUsers().Select(x => x.Name).ToList());
        PoolList = new ObservableCollection<string>(ImageEngine.GetPools().Select(x => x.Name).ToList());
    }

    public void CreateNewPost()
    {
        Console.WriteLine(JsonSerializer.Serialize(ImageEngine.GetPools().ToList() + " ------------------------- " + PoolName));
        var e = ImageEngine.GetPools().First(x => x.Name == PoolName);
        ImageEngine.AddPost(new Post(TitleText, 1,e.Id , DateTime.Now, PathText));
    }

    public async void ChooseFile()
    {
        var b = await App.window.StorageProvider.OpenFilePickerAsync(new FilePickerOpenOptions()
        {
            Title = "Choose a File",
            FileTypeFilter = new []
            {
                new FilePickerFileType(".png"),
                new FilePickerFileType(".jpg")
            },
        });

        PathText = b.First().Path.AbsolutePath;
        this.RaisePropertyChanged(nameof(PathText));
    }
}