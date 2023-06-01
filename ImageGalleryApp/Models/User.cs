using System;

namespace ImageGalleryApp.Models;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime CreationDate { get; set; }

    public User()
    {
    }

    public User(int id, string name, DateTime creationDate)
    {
        Id = id;
        Name = name;
        CreationDate = creationDate;
    }
}