using Avalonia;
using Avalonia.Markup;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using System;
using System.Globalization;
using Avalonia.Data.Converters;

namespace AvalonStudio.Extensibility.Converters
{
    public class BitmapAssetConverter : IValueConverter
    {
        public static BitmapAssetConverter Instance = new BitmapAssetConverter();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
                var assets = AvaloniaLocator.Current.GetService<IAssetLoader>();
                return new Bitmap(assets.Open(new Uri($"avares://ImageGalleryApp{value}")));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}