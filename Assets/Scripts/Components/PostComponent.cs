using Unity.Collections;
using Unity.Entities;

public struct PostComponent : IComponentData
{
    public FixedString32Bytes category;
    public FixedString32Bytes topic;
    public int postId;
    public int views;
    public int replies;
    public int likes;
    public FixedString32Bytes author;
    public FixedString64Bytes title;
    public FixedString512Bytes content;
}
