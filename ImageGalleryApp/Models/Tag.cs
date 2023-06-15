namespace ImageGalleryApp.Models;

public class Tag
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int? ImpliesId { get; set; }
    public virtual Tag? Implies { get; set; }

    public Tag()
    {
    }

    public Tag(string name, int? impliesId, Tag? implies)
    {
        Name = name;
        ImpliesId = impliesId;
        Implies = implies;
    }
}