namespace Ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;

            for (int i = 1; i <= 20; i++)
            {
                if (i % 3 == 0)
                {
                    suma += i;
                }
            }

            Console.WriteLine("La suma de todos los enteros de 1 a 20 que son divisibles entre 3 es: " + suma);
        }
    }
}
