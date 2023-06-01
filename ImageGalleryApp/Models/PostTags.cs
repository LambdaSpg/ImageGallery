namespace ImageGalleryApp.Models;

public class PostTags
{
    public int PostId { get; set; }
    public Post Post { get; set; }
    
    public int TagId { get; set; }
    public Tag Tag { get; set; }

    public PostTags()
    {
    }

    public PostTags(int postId, Post post, int tagId, Tag tag)
    {
        PostId = postId;
        Post = post;
        TagId = tagId;
        Tag = tag;
    }
}