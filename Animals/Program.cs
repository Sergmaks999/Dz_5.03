using System;

public class Animal
{
    public string Name { get; set; }
    public double Weight { get; set; }
    public string Breed { get; set; }
    public DateTime DateOfBirth { get; set; }

    public Animal(string name, double weight, string breed, DateTime dateOfBirth)
    {
        Name = name;
        Weight = weight;
        Breed = breed;
        DateOfBirth = dateOfBirth;
    }

    public virtual string GetInfo()
    {
        return $"Имя: {Name}, Вес: {Weight}, Порода: {Breed}, Дата рождения: {DateOfBirth.ToShortDateString()}";
    }
}

public class Cat : Animal
{
    public Cat(string name, double weight, string breed, DateTime dateOfBirth)
        : base(name, weight, breed, dateOfBirth)
    {
    }

    public bool CatchMouse()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 101);

        return randomNumber > 50;
    }

    public override string GetInfo()
    {
        return $"Котик: {base.GetInfo()}";
    }
}

public class Parrot : Animal
{
    public Parrot(string name, double weight, string breed, DateTime dateOfBirth)
        : base(name, weight, breed, dateOfBirth)
    {
    }

    public override string GetInfo()
    {
        return $"Попугайчик: {base.GetInfo()}";
    }
}

public class Example
{
    public static void Main(string[] args)
    {
        Cat cat = new Cat("Барсик", 4.5, "Сиамский", DateTime.Parse("2022-05-10"));
        Parrot parrot = new Parrot("Кеша", 0.2, "Волнистый", DateTime.Parse("2023-01-15"));

        Console.WriteLine(cat.GetInfo());
        Console.WriteLine(parrot.GetInfo());

        if (cat.CatchMouse())
        {
            Console.WriteLine($"{cat.Name} поймал мышку!");
        }
        else
        {
            Console.WriteLine($"{cat.Name} не поймал мышку.");
        }
    }
}