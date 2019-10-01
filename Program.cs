using System;

namespace Arrayer_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tal = new int[5];
            
            for(int i = 0; i < tal.GetLength(0); i++)
            {
                Console.Write("Skriv ett tal: ");
                String x = Console.ReadLine();
                int.TryParse(x, out int Tal);
                tal[i] = Tal;
            }
            Console.WriteLine("Din array baklänges: " + tal[4] + tal[3]+ tal[2]+ tal[1]+ tal[0]);
        }
    }
}
