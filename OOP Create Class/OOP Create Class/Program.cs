using System;

class Car
{
    public string Brand { get; set; }
    public int Speed { get; set; }

    public Car(string brand, int speed)
    {
        Brand = brand;
        Speed = speed;
    }

    public void Accelerate(int increase)
    {
        Speed += increase;
        Console.WriteLine($"{Brand} is now going at {Speed} km/h");
    }

    static void Main()
    {
        Car car1 = new Car("Toyota", 60);
        car1.Accelerate(20);
    }
}
