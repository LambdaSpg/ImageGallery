using System;

namespace ImageGalleryApp.Models;

public class Post
{
    public int Id { get; set; }
    public string Title { get; set; }
    //TODO Fluent API
    public int AuthorId { get; set; }
    public User Author { get; set; }
    
    public int PoolId { get; set; }
    public Pool Pool { get; set; }
    
    public DateTime CreationDate { get; set; }
    
    public string Path { get; set; }

    public Post()
    {
    }

    public Post(int id, string title, int authorId, User author, int poolId, Pool pool, DateTime creationDate)
    {
        Id = id;
        Title = title;
        AuthorId = authorId;
        Author = author;
        PoolId = poolId;
        Pool = pool;
        CreationDate = creationDate;
    }
}