namespace ImageGalleryApp.Models;

public class PostTags
{
    public int PostId { get; set; }
    public virtual Post Post { get; set; }
    
    public int TagId { get; set; }
    public virtual Tag Tag { get; set; }

    public PostTags()
    {
    }

    public PostTags(int postId,  int tagId)
    {
        PostId = postId;
        TagId = tagId;
    }
}