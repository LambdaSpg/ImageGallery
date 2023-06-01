namespace ImageGalleryApp.Models;

public class Pool
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Pool()
    {
    }

    public Pool(int id, string name)
    {
        Id = id;
        Name = name;
    }
}
