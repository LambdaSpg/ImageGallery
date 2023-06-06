using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.Json;
using ImageGalleryApp.Models;
using ImageGalleryApp.Modules;

namespace ImageGalleryApp.Avalonia.ViewModel.Tabs;

public class UploadTabViewModel : ViewModelBase
{
    public ObservableCollection<String> PoolList { get; set; }

    public UploadTabViewModel()
    {
        UpdatePoolContents();
        Console.WriteLine(JsonSerializer.Serialize(PoolList));
    }


    public void UpdatePoolContents()
    {
        PoolList = new ObservableCollection<string>(ImageEngine.GetPools().Select(x => x.Name).ToList());
    }
}