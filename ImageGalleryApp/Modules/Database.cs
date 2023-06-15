using System;
using System.Collections.Generic;
using Avalonia.OpenGL.Egl;
using ImageGalleryApp.Models;
using ImageGalleryApp.Structure;

namespace ImageGalleryApp.Modules;

internal class Database
{
    public ImageContext Ctx { get; set; } = null!;

    public Database()
    {
        Ctx = new ImageContext();
    }


    public bool AddPost(Post post)
    {
        Ctx.Posts.Add(post);
        Ctx.SaveChangesAsync();
        return true;
    }
    public bool CheckConnection()
    {
        return Ctx.Database.CanConnect();
    }

    public void RemovePost(Post post)
    {
        Ctx.Posts.Remove(post);
        Ctx.SaveChangesAsync();
    }

    public void RemovePostTag(PostTags postTags)
    {
        Ctx.PostTags.Remove(postTags);
        Ctx.SaveChangesAsync();
    }

    public void AddPostTag(PostTags postTags)
    {
        Ctx.PostTags.Add(postTags);
        Ctx.SaveChangesAsync();
    }

    public void AddTag(Tag tag)
    {
        Ctx.Tags.Add(tag);
        Ctx.SaveChangesAsync();
    }

    public void RemoveTag(Tag tag)
    {
        Ctx.Tags.Remove(tag);
        Ctx.SaveChangesAsync();
    }
}