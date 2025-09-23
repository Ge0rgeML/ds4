internal class Program
{
    private static void Main(string[] args)
    {
        int primerNumero, segundoNumero;
        Console.WriteLine("Ingrese el primer numero");
        primerNumero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo numero");
        segundoNumero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(CalculosMatematicos.Calculo(primerNumero,segundoNumero));
    }
}
public class CalculosMatematicos{
    
    public int Calculo(int a, int b){
        int Resultado = (a + b)*(a - b);
        return Resultado;
    }
}