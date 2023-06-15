using System;
using System.ComponentModel.DataAnnotations;

namespace ImageGalleryApp.Models;

public class Post
{ 
    public int Id { get; set; }
    public string Title { get; set; }
    //TODO Fluent API
    public int AuthorId { get; set; }
    public virtual User Author { get; set; }
    
    public int PoolId { get; set; }
    public virtual Pool Pool { get; set; }
    
    public DateTime CreationDate { get; set; }
    
    public string Path { get; set; }

    public Post(string title, int authorId, int poolId, DateTime creationDate, string path)
    {
        Title = title;
        AuthorId = authorId;
        PoolId = poolId;
        CreationDate = creationDate;
        Path = path;
    }
}