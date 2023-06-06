using System;

namespace ImageGalleryApp.Models;

public class PostDto
{
    
    public int? Id { get; set; }
    public string Title { get; set; }
    //TODO Fluent API
    public int AuthorId { get; set; }
    public User Author { get; set; }
    
    public int PoolId { get; set; }
    public Pool Pool { get; set; }
    
    public DateTime CreationDate { get; set; }
    
    public string Path { get; set; }
}