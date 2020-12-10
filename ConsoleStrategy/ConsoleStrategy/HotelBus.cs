using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleStrategy
{
    public class HotelBus : ITransport
    {
        public void Go()
        {
            Console.WriteLine("go by hotel bus");
        }
    }
}
