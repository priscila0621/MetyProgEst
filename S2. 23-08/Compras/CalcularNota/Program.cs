using CalcularNota.clases;

namespace CalcularNota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejemplo 2, Nota Final");
            Nota NotaFinal = new Nota();
            double nota1, nota2, nota3, notafinal;
            Console.WriteLine("Ingresa tu primera nota: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa tu segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa tu tercer nota: ");
            nota3 = double.Parse(Console.ReadLine());

            NotaFinal.Nota1 = nota1;
            NotaFinal.Nota2 = nota2;
            NotaFinal.Nota3 = nota3;

            notafinal = NotaFinal.calcularNotaFinal();

            Console.WriteLine($"{nota1}");
            Console.WriteLine($"{nota2}");
            Console.WriteLine($"{nota3}");
            Console.WriteLine($"{notafinal}");



        }
    }
}
