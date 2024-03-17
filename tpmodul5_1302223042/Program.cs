public class Program
{
    public static void Main(string[] args)
    {
        HaloGeneric haloGeneric = new HaloGeneric();
        haloGeneric.SapaUser<String>("Iksan Risandy");

        DataGeneric<String> dataGeneric = new DataGeneric<string>("1302223042");
        dataGeneric.PrintData();
    }
}

public class HaloGeneric
{
    public void SapaUser <T>(T x)
    {
        Console.WriteLine("Halo user " + x);
        DataGeneric<String> dataGeneric = new DataGeneric<string>("1302223042");
        dataGeneric.PrintData();
    }
}

public class DataGeneric <T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        T y = this.data;
        Console.WriteLine("Data yang tersimpan adalah: " + y);
    }
}