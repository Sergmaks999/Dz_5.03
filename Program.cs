using System;

public class FeaturesStudent
{
    private string _fio;

    public string FIO
    {
        get { return _fio; }
        set { _fio = value; }
    }

    private readonly int _recordBookNumber;

    public int RecordBookNumber
    {
        get { return _recordBookNumber; }
    }

    private readonly string _groupNumber;

    public string GroupNumber
    {
        get { return _groupNumber; }
    }


    public string SNILS { get; }

    public string Information
    {
        get
        {
            return $"ФИО: {FIO}, Группа: {GroupNumber}, Номер зачетки: {RecordBookNumber}, СНИЛС: {SNILS}";
        }
    }

    public FeaturesStudent(string fio, string groupNumber, int recordBookNumber, string snils)
    {
        _fio = fio;
        _groupNumber = groupNumber;
        _recordBookNumber = recordBookNumber;
        SNILS = snils;
    }

    public void PrintInfo()
    {
        Console.WriteLine(Information);
    }
}

public class MethodStudent
{
    private string _fio;
    private string _groupNumber;
    private int _recordBookNumber;
    private string _snils;

    public MethodStudent(string fio, string groupNumber, int recordBookNumber, string snils)
    {
        _fio = fio;
        _groupNumber = groupNumber;
        _recordBookNumber = recordBookNumber;
        _snils = snils;
    }

    public string GetFIO()
    {
        return _fio;
    }

    public void SetFIO(string fio)
    {
        _fio = fio;
    }

    public string GetGroupNumber()
    {
        return _groupNumber;
    }

    public int GetRecordBookNumber()
    {
        return _recordBookNumber;
    }

    public string GetSNILS()
    {
        return _snils;
    }


    public string GetInformation()
    {
        return $"ФИО: {_fio}, Группа: {_groupNumber}, Номер зачетки: {_recordBookNumber}, СНИЛС: {_snils}";
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
        FeaturesStudent student1 = new FeaturesStudent("Иванов Иван Иванович", "ИСиП-201", 123456, "123-456-789 00");
        student1.FIO = "Петров Петр Петрович";
        Console.WriteLine("Информация о студенте (FeaturesStudent):");
        student1.PrintInfo();

        Console.WriteLine($"Номер зачетки: {student1.RecordBookNumber}");
        Console.WriteLine($"Группа: {student1.GroupNumber}");

        MethodStudent student2 = new MethodStudent("Сидоров Сидор Сидорович", "ИСиП-202", 654321, "009-876-543 01");
        student2.SetFIO("Смирнов Семен Семенович");
        Console.WriteLine("\nИнформация о студенте (MethodStudent):");
        student2.PrintInfo();
        Console.WriteLine($"Номер зачетки: {student2.GetRecordBookNumber()}");
        Console.WriteLine($"Группа: {student2.GetGroupNumber()}");
        Console.WriteLine($"СНИЛС: {student2.GetSNILS()}");
    }
}