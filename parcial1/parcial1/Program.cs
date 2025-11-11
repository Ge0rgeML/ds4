using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Tamaño de la matriz: ");
        if (!int.TryParse(Console.ReadLine(), out int n)|| n <= 0 )
        {
            Console.WriteLine("El numero debe ser positivo");
            return;
        }
        int[,] matriz = new int[n, n];

        for (int j = 0; j < n; j++) 
            matriz[0, j] = j + 1;

        if (n > 1)
           for (int j = 0; j < n; j++)
                matriz[n - 1, j] = n - j;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++) Console.Write(matriz[i, j]);
            Console.WriteLine();
        }
    }
}