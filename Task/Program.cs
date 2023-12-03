public class Vehicle
{
    protected int weight;
    protected int maxSpeed;

    public Vehicle(int weight, int maxSpeed)
    {
        this.weight = weight;
        this.maxSpeed = maxSpeed;
    }
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Это транспортное средство с весом {weight} и максимальной скоростью {maxSpeed}");
    }
}

public class Car : Vehicle
{
    public Car(int weight, int maxSpeed, int doors, string fuel) : base(weight, maxSpeed)
    {
        this.doors = doors;
        this.fuel = fuel;
    }

    protected int doors;
    protected string fuel;

    public override void DisplayInfo()
    {
        Console.WriteLine($"Это машина с {doors} дверями и с топливом {fuel}");
    }

}

public class Truck : Vehicle 
{
    protected int capacity;

    public Truck(int weight, int maxSpeed, int capacity) : base(weight, maxSpeed)
    {
        this.capacity = capacity;
    }

    public override void DisplayInfo() 
    {
        Console.WriteLine($"Это уже грузовик с грузоподъёмностью {capacity}");
    }
}

public class ElectricCar : Car
{
    protected int range;
    protected int charge;

    public ElectricCar(int weight, int maxSpeed, int doors, string fuel, int range, int charge) : base(weight, maxSpeed, doors, fuel)
    {
        this.range = range;
        this.charge = charge;
    }

    public new void DisplayInfo()
    {
        Console.WriteLine($"Это электромобиль с дальностью {range} и уровнем заряда {charge}");
    }
}

public class Program
{
    public static void Main()
    {
        Vehicle vehicle = new Vehicle(50, 150);
        vehicle.DisplayInfo();

        vehicle = new Car(60, 160, 4, "бензин");
        vehicle.DisplayInfo();

        vehicle = new Truck(70, 170, 500);
        vehicle.DisplayInfo();

        vehicle = new ElectricCar(80, 180, 6, "дизель", 600, 700);
        vehicle.DisplayInfo();

        ElectricCar electriccar = new ElectricCar(90, 190, 7, "дизель", 600, 700);
        electriccar.DisplayInfo();
    }
}


