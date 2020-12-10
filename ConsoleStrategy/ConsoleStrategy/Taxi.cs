using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleStrategy
{
    public class Taxi : ITransport
    {
        public void Go()
        {
            Console.WriteLine("go by taxi");
        }
    }
}
