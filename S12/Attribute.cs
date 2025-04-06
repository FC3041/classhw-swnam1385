// Vehicles.cs
public interface IVehicle
{
    double Area();
    double Perimeter();
    int GetCapacity();
}

public class Bicycle : IVehicle
{
    private double length;
    private double width;
    private int capacity;

    public Bicycle(double l, double w, int c)
    {
        length = l;
        width = w;
        capacity = 1;
    }

    public double Area() => length * width;
    public double Perimeter() => 2 * (length + width);
    public int GetCapacity() => capacity;
}

public class Car : IVehicle
{
    private double length;
    private double width;
    private int capacity;

    public Car(double l, double w, int c)
    {
        length = l;
        width = w;
        capacity = 5;
    }

    public double Area() => length * width;
    public double Perimeter() => 2 * (length + width);
    public int GetCapacity() => capacity;
}

public class Bus : IVehicle
{
    private double length;
    private double width;
    private int capacity;

    public Bus(double l, double w, int c)
    {
        length = l;
        width = w;
        capacity = 25;
    }

    public double Area() => length * width;
    public double Perimeter() => 2 * (length + width);
    public int GetCapacity() => capacity;
}

public class Train : IVehicle
{
    private double length;
    private double width;
    private int capacity;

    public Train(double l, double w, int c)
    {
        length = l;
        width = w;
        capacity = 500;
    }

    public double Area() => length * width;
    public double Perimeter() => 2 * (length + width);
    public int GetCapacity() => capacity;
}
