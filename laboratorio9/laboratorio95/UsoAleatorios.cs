using System;
using System.Linq;
using laboratorio95;

class UsoAleatorios
{
    static void Main()
    {
        Aleatorios aleatorios = new Aleatorios();
        Console.Write("Ingrese el límite inferior: ");
        int min = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el límite superior: ");
        int max = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el tamaño del arreglo: ");
        int tamano = Convert.ToInt32(Console.ReadLine());

        int[] numeros = aleatorios.GenerarArreglo(min, max, tamano);

        numeros = numeros.Distinct().ToArray();

        Console.WriteLine("Arreglo de números no repetidos:");

        foreach (int num in numeros)
        {
            Console.WriteLine(num);
        }
    }
}

