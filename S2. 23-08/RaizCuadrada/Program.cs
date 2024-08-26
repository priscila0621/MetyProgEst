using RaizCuadrada.clases;

namespace RaizCuadrada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejemplo 4, Raiz Cuadrada");
            Raiz raiz = new Raiz();
            double numero, raiznumero;
            Console.WriteLine("Ingresa el numero: ");
            numero = double.Parse(Console.ReadLine());

            raiz.Numero = numero;

            raiznumero = raiz.CalcularRaiz();

            Console.Write($"La raiz cuadrada de {numero} es: ");
            Console.Write($"{raiznumero}");
        }
    }
}
