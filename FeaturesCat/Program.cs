using System;

public class FeaturesCat
{
    private string _name; 
    private double _height;
    private double _weight;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public double Height
    {
        get { return _height; }
        set { _height = value; }
    }

    public double Weight
    {
        get { return _weight; }
        set { _weight = value; }
    }

    private readonly string _breed;

    public string Breed
    {
        get { return _breed; }
    }

    public string Owner { get; }

    public string Information
    {
        get
        {
            return $"Кличка: {Name}, Порода: {Breed}, Рост: {Height}, Вес: {Weight}, Хозяин: {Owner}";
        }
    }

    public FeaturesCat(string name, string breed, double height, double weight, string owner)
    {
        _name = name;
        _breed = breed;
        _height = height;
        _weight = weight;
        Owner = owner;
    }

    public void PrintInfo()
    {
        Console.WriteLine(Information);
    }
}

public class MethodCat
{
    private string _name;
    private string _breed;
    private double _height;
    private double _weight;
    private string _owner;

    public MethodCat(string name, string breed, double height, double weight, string owner)
    {
        _name = name;
        _breed = breed;
        _height = height;
        _weight = weight;
        _owner = owner;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetBreed()
    {
        return _breed;
    }

    public double GetHeight()
    {
        return _height;
    }

    public void SetHeight(double height)
    {
        _height = height;
    }

    public double GetWeight()
    {
        return _weight;
    }

    public void SetWeight(double weight)
    {
        _weight = weight;
    }

    public string GetOwner()
    {
        return _owner;
    }

    public string GetInformation()
    {
        return $"Кличка: {_name}, Порода: {_breed}, Рост: {_height}, Вес: {_weight}, Хозяин: {_owner}";
    }

    public void PrintInfo()
    {
        Console.WriteLine(GetInformation());
    }
}


public class Example
{
    public static void Main(string[] args)
    {
        FeaturesCat cat1 = new FeaturesCat("Мурзик", "Сиамская", 25, 4.5, "Иван");
        cat1.Name = "Барсик";
        cat1.Height = 28;
        cat1.Weight = 5.0;

        Console.WriteLine("Информация о котике (FeaturesCat):");
        cat1.PrintInfo();


        Console.WriteLine($"Порода: {cat1.Breed}");
        Console.WriteLine($"Хозяин: {cat1.Owner}");


        MethodCat cat2 = new MethodCat("Снежок", "Британская", 23, 4.0, "Анна");
        cat2.SetName("Пушок");
        cat2.SetHeight(24);
        cat2.SetWeight(4.2);
        Console.WriteLine("\nИнформация о котике (MethodCat):");
        cat2.PrintInfo();

        Console.WriteLine($"Порода: {cat2.GetBreed()}");
        Console.WriteLine($"Хозяин: {cat2.GetOwner()}");
    }
}