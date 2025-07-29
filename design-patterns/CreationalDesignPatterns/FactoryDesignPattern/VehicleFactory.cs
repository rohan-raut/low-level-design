using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    internal class VehicleFactory
    {
        public static IVehicle? GetVehicle(string? vehicleType)
        {
            IVehicle? vehicle = null;

            if(vehicleType == "Truck")
            {
                vehicle = new Truck();
            }
            else if(vehicleType == "Ship")
            {
                vehicle = new Ship();
            }

            return vehicle;
        }
    }
}

/*
 * If the if-else ladder becomes to big in GetVehicle method then we can create different concrete factory classes like TruckFactory, CarFactory
 * ShipFactory, etc.
 * And IFactory will be the interface for all the concrete factory classes with methods of CreateVehicle which will be implemented by them.
 * If the client wants Truck, IFactory vehicle = TruckFactory.CreateVehicle();
 * This may start converting to Abstract Factory Design Pattern.
 * 
 */
