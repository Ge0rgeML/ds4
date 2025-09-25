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
        double radio;

        Console.WriteLine("ingrese el radio de su circulo para saber el area: ");
        radio = Convert.ToInt32(Console.ReadLine());

        CalculosMatematicos calmat = new CalculosMatematicos();
        double resultado = calmat.AreaC(radio);
        Console.WriteLine($"El area del circulo con radio de {radio} es: {resultado} ");
    }
}