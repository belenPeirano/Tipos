using System;

public class Car : IElectric, ILikeable
{
    private String model;
    private Boolean isOn;
    private Int32 likes;

    public Car(String model)
    {
        this.model = model;
        this.isOn = false;
        this.likes = 0;
    }

    public String Model
    {
        get
        {
            return this.model;
        }
    }

    public Boolean IsOn
    {
        get
        {
            return this.isOn;
        }
    }

    public Int32 Likes
    {
        get
        {
            return this.likes;
        }
    }

    public void TurnOn()
    {
        this.isOn = true;
    }

    public void TurnOff()
    {
        this.isOn = false;
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