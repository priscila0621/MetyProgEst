using Cubo.clases;

namespace Cubo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejemplo 3, Cubo de un numero");
            CuboNumero cubo = new CuboNumero();
            double numero, numerocubo;
            Console.WriteLine("Ingresa el numero: ");
            numero = double.Parse(Console.ReadLine());

            cubo.Numero = numero;

            numerocubo = cubo.CalcularCubo();

            Console.Write($"El cubo de {numero} es: ");
            Console.Write($"{numerocubo}");
        }
    }
}
