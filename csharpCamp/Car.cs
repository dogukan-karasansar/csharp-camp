using System;

class Car
{
    public string model;
    public int year;
    public string color;

    public Car(string model, int year, string color)
    {
        this.model = model;
        this.color = color;
        this.year = year;
    }

    public static void message()
    {
        Console.WriteLine("Your car");
    }
}