using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleStrategy
{
    public class PersonalVehicle : ITransport
    {
        public void Go()
        {
            Console.WriteLine("go by personal vehicle");
        }
    }
}
