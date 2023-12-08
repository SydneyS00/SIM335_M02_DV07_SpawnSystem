using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IVehicle 
{
    //This will display our starting text along with what kind of vehicle we pick 
    string Start(); 
}

public class Unicycle : IVehicle 
{
    public string Start()
    {
        return ("I am a unicycle! You ready for the circus now!!"); 
    }
}
public class Bicycle : IVehicle 
{
    public string Start()
    {
        return ("I am a bicycle! Finally free from the training wheels!!"); 
    }
}
public class Tandem : IVehicle 
{
    public string Start()
    {
        return ("I am a tandem! Whatever that is!!");
    }
}
public class Tricycle : IVehicle 
{
    public string Start()
    {
        return ("I am a tricycle! Forever stuck with training wheels!!"); 
    }
}
public class GoKart : IVehicle 
{
    public string Start()
    {
        return ("I am a go kart! No bumping allowed!!"); 
    }
}
public class FamilyBike : IVehicle 
{
    public string Start()
    {
        return ("I am a family bike! Don't forget the cat in the basket!!"); 
    }
}
public class Car : IVehicle 
{
    public string Start()
    {
        return ("I am a car...that's it..");
    }
}
public class Motorbike : IVehicle 
{
    public string Start()
    {
        return ("I am a motorbike! Remember your leather jacket and helmet!!"); 
    }
}
public class Truck : IVehicle 
{
    public string Start()
    {
        return ("I am a truck! Time to go to the tail gate!!"); 
    }
}


