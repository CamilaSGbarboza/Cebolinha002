using System;

namespace Cebolinha002
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("digite:");
            string cebolinha = Console.ReadLine();
            Console.WriteLine($"{cebolinha.Replace("rr","l").Replace("rR","l").Replace("RR","L").Replace("Rr","L").Replace("R","L").Replace("r", "l")}");
        }
    }
}
