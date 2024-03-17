public class Program
{
    public static void Main(string[] args)
    {
        HaloGeneric haloGeneric = new HaloGeneric();
        haloGeneric.SapaUser<String>("Iksan Risandy");
    }
}

public class HaloGeneric
{
    public void SapaUser <T>(T x)
    {
        Console.WriteLine("Halo user " + x);
    }
}