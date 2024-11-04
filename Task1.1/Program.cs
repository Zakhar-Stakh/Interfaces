using System;

interface IVehicle
{
    void Start();
    void Stop();
    void Drive();
}

class Car : IVehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    public void Start()
    {
        Console.WriteLine($"Starting the car: {Make} {Model} ({Year})");
    }

    public void Stop()
    {
        Console.WriteLine($"Stopping the car: {Make} {Model}");
    }

    public void Drive()
    {
        Console.WriteLine($"Driving the car: {Make} {Model}");
    }

    public void Honk()
    {
        Console.WriteLine("Beep beep!");
    }
}

class Motorcycle : IVehicle
{
    public string Brand { get; set; }
    public int EngineCapacity { get; set; } 

    public Motorcycle(string brand, int engineCapacity)
    {
        Brand = brand;
        EngineCapacity = engineCapacity;
    }

    public void Start()
    {
        Console.WriteLine($"Starting the motorcycle: {Brand} ({EngineCapacity} cc)");
    }

    public void Stop()
    {
        Console.WriteLine($"Stopping the motorcycle: {Brand}");
    }

    public void Drive()
    {
        Console.WriteLine($"Riding the motorcycle: {Brand}");
    }

    public void RevEngine()
    {
        Console.WriteLine("Vroom vroom!");
    }
}

class Truck : IVehicle
{
    public string Company { get; set; }
    public double LoadCapacity { get; set; } 

    public Truck(string company, double loadCapacity)
    {
        Company = company;
        LoadCapacity = loadCapacity;
    }

    public void Start()
    {
        Console.WriteLine($"Starting the truck: {Company} with load capacity of {LoadCapacity} tons");
    }

    public void Stop()
    {
        Console.WriteLine($"Stopping the truck: {Company}");
    }

    public void Drive()
    {
        Console.WriteLine($"Driving the truck: {Company}");
    }

    public void LoadCargo()
    {
        Console.WriteLine("Loading cargo...");
    }
}

class Program
{
    static void Main()
    {
        // Створення об'єктів різних транспортних засобів
        IVehicle myCar = new Car("Toyota", "Camry", 2021);
        IVehicle myMotorcycle = new Motorcycle("Yamaha", 600);
        IVehicle myTruck = new Truck("Volvo", 10.5);

        // Тестування методів для кожного транспортного засобу
        myCar.Start();
        myCar.Drive();
        myCar.Stop();
        ((Car)myCar).Honk(); // Виклик методу, специфічного для Car

        Console.WriteLine();

        myMotorcycle.Start();
        myMotorcycle.Drive();
        myMotorcycle.Stop();
        ((Motorcycle)myMotorcycle).RevEngine(); // Виклик методу, специфічного для Motorcycle

        Console.WriteLine();

        myTruck.Start();
        myTruck.Drive();
        myTruck.Stop();
        ((Truck)myTruck).LoadCargo(); // Виклик методу, специфічного для Truck
    }
}