using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleStrategy
{
    public class Transportation
    {
        private ITransport transport;

        public void GetToAirport(int maxCost)
        {
            if(maxCost <= 100)
            {
                transport = new PersonalVehicle();
            }
            else if (maxCost > 100 && maxCost <= 200)
            {
                transport = new Taxi();
            }
            else if (maxCost > 200 && maxCost <= 300)
            {
                transport = new HotelBus();
            }
            else if (maxCost > 300)
            {
                transport = new Limo();
            }
            transport.Go();
        }
    }
}
