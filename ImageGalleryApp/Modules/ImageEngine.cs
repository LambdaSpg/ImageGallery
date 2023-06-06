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

    public static IEnumerable<Post> GetPosts()
    {
        return Database.Ctx.Posts.ToList();
    }

    public static IEnumerable<Post> GetPosts(int i)
    {
        return Database.Ctx.Posts.OrderBy(x => x.CreationDate).Take(i).ToList();
    }

    public static List<Pool> GetPools()
    {
        return Database.Ctx.Pools.ToList();
    }
}