using System;

class PagoProducto
{
    static void Main()
    {
        Console.Write("Ingrese el precio del producto (valor positivo): ");
        double precio = Convert.ToDouble(Console.ReadLine());

        if (precio > 0)
        {
            Console.Write("Ingrese la forma de pago (efectivo/tarjeta): ");
            string formaPago = Console.ReadLine();

            if (formaPago.ToLower() == "tarjeta")
            {
                Console.Write("Ingrese el número de cuenta (16 dígitos): ");
                string numeroCuenta = Console.ReadLine();

                if (numeroCuenta.Length == 16)
                {
                    Console.WriteLine("Pago realizado con tarjeta.");
                }
                else
                {
                    Console.WriteLine("Número de cuenta inválido.");
                }
            }
            else if (formaPago.ToLower() == "efectivo")
            {
                Console.WriteLine("Pago realizado en efectivo.");
            }
            else
            {
                Console.WriteLine("Forma de pago no reconocida.");
            }
        }
        else
        {
            Console.WriteLine("El precio debe ser positivo.");
        }
    }
}

