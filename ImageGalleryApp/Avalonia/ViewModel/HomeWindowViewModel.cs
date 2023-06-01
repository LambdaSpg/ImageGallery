using System;
using Avalonia.Layout;
using ImageGalleryApp.Avalonia.View.Tabs;
using ImageGalleryApp.Avalonia.ViewModel.Tabs;

namespace ImageGalleryApp.Avalonia.ViewModel;

public class HomeWindowViewModel : ViewModelBase
{
   public ViewTabViewModel ViewTabViewModel => new ViewTabViewModel();

   public HomeWindowViewModel()
   {
      Console.WriteLine("Initialized Homewindow");
   }
}