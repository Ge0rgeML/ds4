using System;

internal class Program
{
    private static long[] GenerarSucesion(int n)
    {
        long[] resultado = new long[n];
        long valor = 2;
        int signo = 1;

        for (int i = 0; i < n; i++)
        {
            resultado[i] = signo * valor;
            valor *= 2;
            signo = -signo;  
        }

        return resultado;
    }

    private static void Main(string[] args)
    {
        Console.Write("Ingresar n: ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n < 1)
        {
            Console.WriteLine("Error intente con positivo");
            return;
        }

        long[] sucesion = GenerarSucesion(n);
        Console.WriteLine(string.Join(", ", sucesion));
    }
}