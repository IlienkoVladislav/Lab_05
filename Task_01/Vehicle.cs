using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    abstract class Vehicle
    {
        public int Speed { get; set; }
        public int Capacity { get; set; }
        public List<string> Passengers { get; set; } = new List<string>();

        public abstract void Move();
    }

    class Car : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Driving a car...");
            Console.WriteLine($"Passengers in the car: {string.Join(", ", Passengers)}");
        }

        public void BoardPassenger(string passenger)
        {
            if (Passengers.Count < Capacity)
            {
                Passengers.Add(passenger);
                Console.WriteLine($"{passenger} boarded the car.");
            }
            else
            {
                Console.WriteLine($"The car is already full. {passenger} cannot board.");
            }
        }

        public void DisembarkPassenger(string passenger)
        {
            if (Passengers.Contains(passenger))
            {
                Passengers.Remove(passenger);
                Console.WriteLine($"{passenger} disembarked from the car.");
            }
            else
            {
                Console.WriteLine($"{passenger} is not in the car.");
            }
        }
    }

    class Bus : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Taking a bus...");
            Console.WriteLine($"Passengers in the bus: {string.Join(", ", Passengers)}");
        }

        public void BoardPassenger(string passenger)
        {
            if (Passengers.Count < Capacity)
            {
                Passengers.Add(passenger);
                Console.WriteLine($"{passenger} boarded the bus.");
            }
            else
            {
                Console.WriteLine($"The bus is already full. {passenger} cannot board.");
            }
        }

        public void DisembarkPassenger(string passenger)
        {
            if (Passengers.Contains(passenger))
            {
                Passengers.Remove(passenger);
                Console.WriteLine($"{passenger} disembarked from the bus.");
            }
            else
            {
                Console.WriteLine($"{passenger} is not in the bus.");
            }
        }
    }

    class Train : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Riding a train...");
            Console.WriteLine($"Passengers in the train: {string.Join(", ", Passengers)}");
        }

        public void BoardPassenger(string passenger)
        {
            if (Passengers.Count < Capacity)
            {
                Passengers.Add(passenger);
                Console.WriteLine($"{passenger} boarded the train.");
            }
            else
            {
                Console.WriteLine($"The train is already full. {passenger} cannot board.");
            }
        }

        public void DisembarkPassenger(string passenger)
        {
            if (Passengers.Contains(passenger))
            {
                Passengers.Remove(passenger);
                Console.WriteLine($"{passenger} disembarked from the train.");
            }
            else
            {
                Console.WriteLine($"{passenger} is not in the train.");
            }
        }
    }

    class TransportNetwork
    {
        private List<Vehicle> vehicles = new List<Vehicle>();

        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public void ControlTraffic()
        {
            foreach (var vehicle in vehicles)
            {
                vehicle.Move();
            }
        }
    }
}
