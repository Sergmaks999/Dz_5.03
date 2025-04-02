using System;

public class Attraction
{
    public string Name { get; set; }
    public int RideDuration { get; set; } 
    public int MaxCapacity { get; set; }

    public Attraction(string name, int rideDuration, int maxCapacity)
    {
        Name = name;
        RideDuration = rideDuration;
        MaxCapacity = maxCapacity;
    }

    public virtual string GetInfo()
    {
        return $"Название: {Name}, Продолжительность: {RideDuration} мин., Макс. вместимость: {MaxCapacity}";
    }
}

public class Tower : Attraction
{
    public double RidePrice { get; set; }

    public Tower(string name, int rideDuration, int maxCapacity, double ridePrice)
        : base(name, rideDuration, maxCapacity)
    {
        RidePrice = ridePrice;
    }

    public double CalculateRevenue(int? numberOfPeople = null)
    {
        int people = numberOfPeople ?? MaxCapacity;
        return people * RidePrice;
    }

    public override string GetInfo()
    {
        return $"Башня: {base.GetInfo()}, Цена: {RidePrice}";
    }
}

public class RollerCoaster : Attraction
{
    public double RidePrice { get; set; }

    public RollerCoaster(string name, int rideDuration, int maxCapacity, double ridePrice)
        : base(name, rideDuration, maxCapacity)
    {
        RidePrice = ridePrice;
    }

    public double CalculateRevenue(int? numberOfPeople = null)
    {
        int people = numberOfPeople ?? MaxCapacity;
        return people * RidePrice;
    }

    public override string GetInfo()
    {
        return $"Американские горки: {base.GetInfo()}, Цена: {RidePrice}";
    }
}


public class Example
{
    public static void Main(string[] args)
    {
        Tower tower = new Tower("Свободное падение", 2, 20, 250);
        RollerCoaster rollerCoaster = new RollerCoaster("Суперпетля", 3, 32, 300);

        Console.WriteLine(tower.GetInfo());
        Console.WriteLine(rollerCoaster.GetInfo());

        double towerRevenue = tower.CalculateRevenue();
        double rollerCoasterRevenue = rollerCoaster.CalculateRevenue();

        Console.WriteLine($"Выручка с \"{tower.Name}\": {towerRevenue}");
        Console.WriteLine($"Выручка с \"{rollerCoaster.Name}\": {rollerCoasterRevenue}");

        double towerRevenueWithPeople = tower.CalculateRevenue(15); 
        double rollerCoasterRevenueWithPeople = rollerCoaster.CalculateRevenue(25);

        Console.WriteLine($"Выручка с \"{tower.Name}\" (15 чел.): {towerRevenueWithPeople}");
        Console.WriteLine($"Выручка с \"{rollerCoaster.Name}\" (25 чел.): {rollerCoasterRevenueWithPeople}");
    }
}