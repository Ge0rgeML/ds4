internal class Program
{
    public class CalculosMatematicos
    {
        public const double PI = Math.PI;
        public int Resultado(int numero1, int numero2)
        {
            return (numero1 + numero2) * (numero1 - numero2);
        }
        public double AreaC(double r)
        {
            return PI * Math.Pow(r, 2);
        }
        public double PerimetroR(double l, double a)
        {
            return 2 * (l + a);
        }
    }
    private static void Main(string[] args)
    {
        int num1, num2;

        Console.WriteLine("ingrese el primer numero: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("ingrese el segundo numero: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        CalculosMatematicos calmat = new CalculosMatematicos();
        int resultado = calmat.Resultado(num1, num2);
        Console.WriteLine($"Resultado de ({num1} + {num2}) * ({num1} - {num2}) es: {resultado} ");
    }
}