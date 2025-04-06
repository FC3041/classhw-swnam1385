// Program.cs
using System.Net.Quic;

namespace S12;

class Program
{
    static void Main(string[] args)
    {
        IVehicle[] vehicles = new IVehicle[]
        {
            new Bicycle(1.8, 0.5, 1),
            new Car(4.5, 1.8, 5),
            new Bus(12.0, 2.5, 50),
            new Train(20.0, 3.2, 200)
        };
        
        double areaSum = 0;
        double perimeterSum = 0;
        double capacitySum = 0;
        
        
        for(int i=0; i<vehicles.Length;i++)
        {
            perimeterSum = vehicles[i].Perimeter();
            areaSum = vehicles[i].Area();
            capacitySum = vehicles[i].GetCapacity();
        }
        
        Console.WriteLine($"Area: {areaSum}");
        Console.WriteLine($"Perimeter: {perimeterSum}");
        Console.WriteLine($"Capacity: {capacitySum}");
    }

}