using System;

interface IProduct
{
    void DisplayInfo();
}

interface IShoppable
{
    void AddToCart();
}

class ElectronicDevice : IProduct
{
    public string Name { get; set; }
    public string Manufacturer { get; set; }
    public decimal Price { get; set; }

    public ElectronicDevice(string name, string manufacturer, decimal price)
    {
        Name = name;
        Manufacturer = manufacturer;
        Price = price;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Product: {Name}, Manufacturer: {Manufacturer}, Price: {Price:C}");
    }
}

class Smartphone : ElectronicDevice, IShoppable
{
    public string OperatingSystem { get; set; }
    public int StorageCapacity { get; set; } 

    public Smartphone(string name, string manufacturer, decimal price, string operatingSystem, int storageCapacity)
        : base(name, manufacturer, price)
    {
        OperatingSystem = operatingSystem;
        StorageCapacity = storageCapacity;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Operating System: {OperatingSystem}, Storage Capacity: {StorageCapacity}GB");
    }

    public void AddToCart()
    {
        Console.WriteLine($"{Name} has been added to the cart.");
    }
}

class Laptop : ElectronicDevice, IShoppable
{
    public string Processor { get; set; }
    public int RAM { get; set; } 

    public Laptop(string name, string manufacturer, decimal price, string processor, int ram)
        : base(name, manufacturer, price)
    {
        Processor = processor;
        RAM = ram;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Processor: {Processor}, RAM: {RAM}GB");
    }

    public void AddToCart()
    {
        Console.WriteLine($"{Name} has been added to the cart.");
    }
}

class Program
{
    static void Main()
    {
        // Створення об'єктів смартфонів
        Smartphone smartphone1 = new Smartphone("Galaxy S21", "Samsung", 799.99m, "Android", 128);
        Smartphone smartphone2 = new Smartphone("iPhone 13", "Apple", 999.99m, "iOS", 256);

        // Створення об'єктів ноутбуків
        Laptop laptop1 = new Laptop("XPS 13", "Dell", 1199.99m, "Intel i7", 16);
        Laptop laptop2 = new Laptop("MacBook Pro", "Apple", 1999.99m, "M1", 32);

        // Виведення інформації про продукти
        smartphone1.DisplayInfo();
        smartphone2.DisplayInfo();
        laptop1.DisplayInfo();
        laptop2.DisplayInfo();

        Console.WriteLine();

        // Додавання до кошика
        smartphone1.AddToCart();
        laptop1.AddToCart();
    }
}