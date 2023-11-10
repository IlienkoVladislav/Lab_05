using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    internal class Program
    {
        static void Main()
        {
            var car = new Car { Speed = 80, Capacity = 4 };
            var bus = new Bus { Speed = 30, Capacity = 20 };
            var train = new Train { Speed = 150, Capacity = 100 };

            var transportNetwork = new TransportNetwork();
            transportNetwork.AddVehicle(car);
            transportNetwork.AddVehicle(bus);
            transportNetwork.AddVehicle(train);

            car.BoardPassenger("Passenger1");
            bus.BoardPassenger("Passenger2");
            train.BoardPassenger("Passenger3");

            transportNetwork.ControlTraffic();

            car.DisembarkPassenger("Passenger1");
            bus.DisembarkPassenger("Passenger2");
            train.DisembarkPassenger("Passenger3");
        }
    }
}
 