using System;
public class Program
{
    public static void Main(String[] args)
    {
        ILikeable likeable;
        IElectric electric;
        String model = "Citroen C4 Cactus";

        Car car = new Car(model);
        likeable = car;
        likeable.Like();
        likeable.Like();
        Console.WriteLine("{0} tiene {1} me gusta", model, car.Likes);

        electric = car;
        electric.TurnOn();
        Console.WriteLine("{0} está prendido: {1}", model, electric.IsOn);

        String name = "John Travolta";
        Actor actor = new Actor(name);
        actor.Like();
        actor.Unlike();
        Console.WriteLine("{0} tiene {1} me gusta", name, actor.Likes);
    }
}