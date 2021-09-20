using System;

public class Actor : ILikeable
{
    private String name;
    private Int32 likes;

    public Actor(String name)
    {
        this.name = name;
    }

    public String Name
    {
        get
        {
            return this.name;
        }
    }

    public Int32 Likes
    {
        get
        {
            return this.likes;
        }
    }

    public void Like()
    {
        this.likes = this.likes + 1;
    }

    public void Unlike()
    {
        if (this.likes > 0)
        {
            this.likes = this.likes - 1;
        }
    }
}