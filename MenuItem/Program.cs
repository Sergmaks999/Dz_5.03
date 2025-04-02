using System;

public class MenuItem
{
    public string Name { get; set; }
    public double Price { get; set; }
    public string Category { get; set; }

    public MenuItem(string name, double price, string category)
    {
        Name = name;
        Price = price;
        Category = category;
    }

    public virtual string GetInfo()
    {
        return $"Название: {Name}, Цена: {Price}, Категория: {Category}";
    }
}

public class Dish : MenuItem
{
    public int Calories { get; set; }
    public double WeightInGrams { get; set; }

    public Dish(string name, double price, string category, int calories, double weightInGrams)
        : base(name, price, category)
    {
        Calories = calories;
        WeightInGrams = weightInGrams;
    }

    public double CalculatePricePerGram()
    {
        return Price / WeightInGrams;
    }

    public override string GetInfo()
    {
        return $"Блюдо: {base.GetInfo()}, Калорийность: {Calories}, Вес: {WeightInGrams} г";
    }
}

public class Drink : MenuItem
{
    public int VolumeInMilliliters { get; set; }

    public Drink(string name, double price, string category, int volumeInMilliliters)
        : base(name, price, category)
    {
        VolumeInMilliliters = volumeInMilliliters;
    }

    public double CalculateDiscountedPrice(double discountPercentage)
    {
        if (discountPercentage < 0 || discountPercentage > 100)
        {
            throw new ArgumentException("Размер скидки должен быть в диапазоне от 0 до 100.");
        }

        return Price * (1 - discountPercentage / 100);
    }

    public override string GetInfo()
    {
        return $"Напиток: {base.GetInfo()}, Объем: {VolumeInMilliliters} мл";
    }
}

public class Example
{
    public static void Main(string[] args)
    {
        Dish pasta = new Dish("Паста Карбонара", 450, "Итальянская кухня", 600, 350);
        Drink juice = new Drink("Апельсиновый сок", 150, "Безалкогольные напитки", 250);

        Console.WriteLine(pasta.GetInfo());
        Console.WriteLine(juice.GetInfo());

        double pricePerGram = pasta.CalculatePricePerGram();
        Console.WriteLine($"Цена одного грамма \"{pasta.Name}\": {pricePerGram:F2}");

        try
        {
            double discountedPrice = juice.CalculateDiscountedPrice(10);
            Console.WriteLine($"Цена \"{juice.Name}\" со скидкой 10%: {discountedPrice:F2}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}