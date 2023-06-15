using System;

namespace ImageGalleryApp.Models;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime CreationDate { get; set; }

    public User(string name, DateTime creationDate){
        Name = name;
        CreationDate = creationDate;
    }
}