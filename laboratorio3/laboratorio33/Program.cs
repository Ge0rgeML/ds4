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
        double largo, ancho;

        Console.WriteLine("ingrese la longitud  de su rectanglo para saber el perimetro: ");
        largo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("ingrese el ancho de su rectanglo para saber el perimetro: ");
        ancho = Convert.ToInt32(Console.ReadLine());

        CalculosMatematicos calmat = new CalculosMatematicos();
        double resultado = calmat.PerimetroR(largo, ancho);
        Console.WriteLine($"Resultado del perimetro de un rectanglo con longitud {largo} y anchura {ancho} es: {resultado} ");
    }
}