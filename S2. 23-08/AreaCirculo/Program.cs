using AreaCirculo.clases;

namespace AreaCirculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejemplo 5, Area del circulo");
            Area area = new Area();
            double radio, areacirculo;
            Console.WriteLine(" Ingrese el radio del circulo: ");
            radio = double.Parse(Console.ReadLine());

            area.Radio = radio;

            areacirculo = area.calcularArea();
            Console.WriteLine($" El area del circulo es de {areacirculo}");
        }
    }
}
