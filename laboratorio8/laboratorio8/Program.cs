using laboratorio8;

internal class Program
{
    private static void Main(string[] args)
    {
        Trabajador p = new Trabajador("Josan", 22, "7758860-Z", 100000);
        Console.WriteLine("Nombre =" +p.Nombre);
        Console.WriteLine("Edad =" + p.Edad);
        Console.WriteLine("NIF =" + p.NIF);
        Console.WriteLine("Sueldo = " + p.Sueldo);
        Console.ReadKey();
    }
}