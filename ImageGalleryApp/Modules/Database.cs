using ImageGalleryApp.Structure;

namespace ImageGalleryApp.Modules;

public class Database
{
    private ImageContext Ctx { get; set; } = null!;

    public Database()
    {
        Ctx = new ImageContext();
    }
}