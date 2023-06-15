using System;
using Avalonia.Layout;
using ImageGalleryApp.Avalonia.View.Tabs;
using ImageGalleryApp.Avalonia.ViewModel.Tabs;

namespace ImageGalleryApp.Avalonia.ViewModel;

public class HomeWindowViewModel : ViewModelBase
{
   private ContentViewModel contentView;
   public ViewTabViewModel ViewTabViewModel => new ViewTabViewModel(contentView);
   public UploadTabViewModel UploadTabViewModel => new UploadTabViewModel();
   public TagTabViewModel TagTabViewModel => new TagTabViewModel();

   public HomeWindowViewModel(ContentViewModel contentViewModel)
   {
      this.contentView = contentViewModel;
      Console.WriteLine("Initialized Homewindow");
      //ViewTabViewModel = new ViewTabViewModel();
   }
}