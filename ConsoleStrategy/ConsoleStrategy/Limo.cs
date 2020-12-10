using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleStrategy
{
    public class Limo : ITransport
    {
        public void Go()
        {
            Console.WriteLine("go by limo");
        }
    }
}
