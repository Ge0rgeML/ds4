internal class Program
{
    private static void Main(string[] args)
    {
        int primerNuemero, segundoNumero, suma;

        Console.WriteLine("Ingrese el primer numero");
        primerNuemero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo numero");
        segundoNumero = Convert.ToInt32(Console.ReadLine());

        suma = primerNuemero + segundoNumero;

        Console.WriteLine("La suma de {0} y {1} es {2}", primerNuemero, segundoNumero, suma);
    }
}