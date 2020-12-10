using System;

namespace ConsoleStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Strategy pattern");

            Transportation t = new Transportation();
            Console.WriteLine("My max cost = 350");
            t.GetToAirport(350);
            Console.WriteLine("My max cost = 30");
            t.GetToAirport(30);
            Console.WriteLine("My max cost = 150");
            t.GetToAirport(150);
        }
    }
}
