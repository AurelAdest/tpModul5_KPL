using System;

class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine($"Halo user {user}");
    }
}

class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine($"Data yang tersimpan adalah: {data}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        HaloGeneric h = new HaloGeneric();
        h.SapaUser<string>("Aurel");

        DataGeneric<string> data = new DataGeneric<string>("103082400041");
        data.PrintData();
    }
}