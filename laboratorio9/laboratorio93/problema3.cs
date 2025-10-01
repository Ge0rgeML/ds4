using System;

class problema3
{
    static void Main()
    {
        Console.Write("Ingrese el primer lado del triángulo: ");
        double lado1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo lado del triángulo: ");
        double lado2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el tercer lado del triángulo: ");
        double lado3 = Convert.ToDouble(Console.ReadLine());

        if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
        {
            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("Es un triángulo equilátero.");
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                Console.WriteLine("Es un triángulo isósceles.");
            }
            else
            {
                Console.WriteLine("Es un triángulo escaleno.");
            }
        }
        else
        {
            Console.WriteLine("No se puede formar un triángulo.");
        }
    }
}

