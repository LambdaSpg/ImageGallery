namespace ImageGalleryApp.Models;

public class Pool
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Pool(string name)
    {
        Name = name;
    }
}
