using ParkingLot.Enums;
using ParkingLot.Models;

namespace ParkingLotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ParkingLot.Models.ParkingLot parkingLot = ParkingLot.Models.ParkingLot.GetInstance();

            ParkingFloor floor1 = new ParkingFloor("F0", 0);
            ParkingSpot spotF11 = new ParkingSpot("F0-1", VehicleSize.SMALL);
            ParkingSpot spotF12 = new ParkingSpot("F0-2", VehicleSize.MEDIUM);
            ParkingSpot spotF13 = new ParkingSpot("F0-3", VehicleSize.LARGE);
            floor1.AddSpot(spotF11);
            floor1.AddSpot(spotF12);
            floor1.AddSpot(spotF13);

            ParkingFloor floor2 = new ParkingFloor("F1", 0);
            ParkingSpot spotF21 = new ParkingSpot("F1-1", VehicleSize.SMALL);
            ParkingSpot spotF22 = new ParkingSpot("F1-2", VehicleSize.MEDIUM);
            ParkingSpot spotF23 = new ParkingSpot("F1-3", VehicleSize.LARGE);
            floor2.AddSpot(spotF21);
            floor2.AddSpot(spotF22);
            floor2.AddSpot(spotF23);

            parkingLot.AddFloor(floor1);
            parkingLot.AddFloor(floor2);

            Vehicle bike1 = new Bike("B123");
            Vehicle bike2 = new Bike("B124");
            Vehicle bike3 = new Bike("B125");
            Vehicle bike4 = new Bike("B126");

            Vehicle car1 = new Car("C123");
            Vehicle car2 = new Car("C124");
            Vehicle car3 = new Car("C125");

            Vehicle truck1 = new Truck("T123");
            Vehicle truck2 = new Truck("T124");




            if (!parkingLot.ParkVehicle(bike1))
            {
                Console.WriteLine("Parking Spot not available!");
            }
            if (!parkingLot.ParkVehicle(bike2))
            {
                Console.WriteLine("Parking Spot not available!");
            }
            if (!parkingLot.ParkVehicle(bike3))
            {
                Console.WriteLine("Parking Spot not available!");
            }
            if (!parkingLot.ParkVehicle(bike4))
            {
                Console.WriteLine("Parking Spot not available!");
            }
            if (!parkingLot.ParkVehicle(car1))
            {
                Console.WriteLine("Parking Spot not available!");
            }
            if (!parkingLot.ParkVehicle(car2))
            {
                Console.WriteLine("Parking Spot not available!");
            }
            if (!parkingLot.ParkVehicle(truck1))
            {
                Console.WriteLine("Parking Spot not available!");
            }
            if (!parkingLot.ParkVehicle(truck2))
            {
                Console.WriteLine("Parking Spot not available!");
            }

            floor1.DisplayAvailability();
            floor2.DisplayAvailability();



        }
    }
}
