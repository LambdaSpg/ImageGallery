using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using ImageGalleryApp.Models;

namespace ImageGalleryApp.Modules;

public class ImageEngine
{
    private static Database Database => new Database();
    
    public static void Init()
    {
        var state = Database.CheckConnection() ? "Successful" : "not established";
        Console.WriteLine($"Connection to the Database was: {state}");
    }

    public static Post GetPost(int id)
    {
        return Database.Ctx.Posts.First(x => x.Id == id);
    }
    
    public static IEnumerable<Post> GetPosts()
    {
        return Database.Ctx.Posts.ToList();
    }

    public static IEnumerable<Post> GetPosts(int i)
    {
        return Database.Ctx.Posts.OrderBy(x => x.CreationDate).Take(i).ToList();
    }

    public static IEnumerable<Pool> GetPools()
    {
        return Database.Ctx.Pools.ToList();
    }

    public static void AddPost(Post post)
    {
        Database.AddPost(post);
    }
    public static void RemovePost(Post post)
    {
        Database.RemovePost(post);
    }

    public static IEnumerable<Tag> GetTags()
    {
        return Database.Ctx.Tags.ToList();
    }
    public static IEnumerable<PostTags> GetPostTags()
    {
        return Database.Ctx.PostTags.ToList();
    }

    public static void RemovePostTag(PostTags postTags)
    {
        Database.RemovePostTag(postTags);
    }

    public static void AddPostTag(PostTags postTags)
    {
        Database.AddPostTag(postTags);
    }

    public static IEnumerable<User> GetUsers()
    {
        return Database.Ctx.Users.ToList();
    }

    public static void AddTag(Tag tag)
    {
        Database.AddTag(tag);
    }

    public static void RemoveTag(Tag tag)
    {
        Database.RemoveTag(tag);
    }
}