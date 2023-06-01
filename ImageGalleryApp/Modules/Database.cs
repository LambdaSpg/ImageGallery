using Avalonia.OpenGL.Egl;
using ImageGalleryApp.Structure;

namespace ImageGalleryApp.Modules;

internal class Database
{
    private ImageContext Ctx { get; set; } = null!;

    public Database()
    {
        Ctx = new ImageContext();
        
    }

    public bool CheckConnection()
    {
        return Ctx.Database.CanConnect();
    }
}