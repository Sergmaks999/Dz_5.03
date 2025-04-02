using System;

public class FeaturesCinema
{
    private string _movieName;

    public string MovieName
    {
        get { return _movieName; }
        set { _movieName = value; }
    }

    private readonly double _ticketPrice;

    public double TicketPrice
    {
        get { return _ticketPrice; }
    }

    public int AudienceCount { get; set; }

    public string Hall { get; }

    public string Information
    {
        get
        {
            return $"Название фильма: {MovieName}, Стоимость билета: {TicketPrice}, Количество зрителей: {AudienceCount}, Зал показа: {Hall}";
        }
    }

    public FeaturesCinema(string movieName, double ticketPrice, int audienceCount, string hall)
    {
        _movieName = movieName;
        _ticketPrice = ticketPrice;
        AudienceCount = audienceCount;
        Hall = hall;
    }

    public void PrintInfo()
    {
        Console.WriteLine(Information);
    }
}

public class MethodCinema
{
    private string _movieName;
    private double _ticketPrice;
    private int _audienceCount;
    private string _hall;

    public MethodCinema(string movieName, double ticketPrice, int audienceCount, string hall)
    {
        _movieName = movieName;
        _ticketPrice = ticketPrice;
        _audienceCount = audienceCount;
        _hall = hall;
    }

    public string GetMovieName()
    {
        return _movieName;
    }

    public void SetMovieName(string movieName)
    {
        _movieName = movieName;
    }

    public double GetTicketPrice()
    {
        return _ticketPrice;
    }

    public int GetAudienceCount()
    {
        return _audienceCount;
    }

    public void SetAudienceCount(int audienceCount)
    {
        _audienceCount = audienceCount;
    }

    public string GetHall()
    {
        return _hall;
    }

    public string GetInformation()
    {
        return $"Название фильма: {_movieName}, Стоимость билета: {_ticketPrice}, Количество зрителей: {_audienceCount}, Зал показа: {_hall}";
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
        FeaturesCinema cinema1 = new FeaturesCinema("Аватар", 350, 150, "Красный зал");
        cinema1.MovieName = "Аватар: Путь воды";
        cinema1.AudienceCount = 180;

        Console.WriteLine("Информация о фильме (FeaturesCinema):");
        cinema1.PrintInfo();


        Console.WriteLine($"Стоимость билета: {cinema1.TicketPrice}");
        Console.WriteLine($"Зал показа: {cinema1.Hall}");


        MethodCinema cinema2 = new MethodCinema("Человек-паук: Нет пути домой", 300, 120, "Зеленый зал");
        cinema2.SetMovieName("Человек-паук: Через вселенные");
        cinema2.SetAudienceCount(140);
        Console.WriteLine("\nИнформация о фильме (MethodCinema):");
        cinema2.PrintInfo();

        Console.WriteLine($"Стоимость билета: {cinema2.GetTicketPrice()}");
        Console.WriteLine($"Зал показа: {cinema2.GetHall()}");
    }
}