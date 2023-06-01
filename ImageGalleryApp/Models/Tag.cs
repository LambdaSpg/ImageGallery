namespace ImageGalleryApp.Models;

public class Tag
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int? ImpliesId { get; set; }
    public Tag? Implies { get; set; }

    public Tag()
    {
    }

    public Tag(int id, string name, int? impliesId, Tag? implies)
    {
        Id = id;
        Name = name;
        ImpliesId = impliesId;
        Implies = implies;
    }
}