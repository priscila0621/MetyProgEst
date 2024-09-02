namespace Anidado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int row = 1; row < 11; row++)
            {
                for (char column = 'a'; column < 'k'; column++)
                {
                    Console.WriteLine($"The cell is ({row}, {column})");
                }
            }
        }
    }
}
