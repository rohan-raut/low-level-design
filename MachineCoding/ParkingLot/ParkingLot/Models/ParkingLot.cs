using ParkingLot.Strategies.Fee;
using ParkingLot.Strategies.Parking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Models
{
    internal class ParkingLot
    {
        private List<ParkingFloor> parkingFloors;
        private IParkingStrategy parkingStrategy;
        private IFeeStrategy feeStrategy;
        private static readonly object mainLock = new object();
        private static readonly object instanceLock = new object();
        private static ParkingLot instance = null;
        private Dictionary<string, ParkingTicket> activeTickets;

        private ParkingLot()
        {
            parkingFloors = new List<ParkingFloor>();
            parkingStrategy = new NearestFirstStrategy();
            feeStrategy = new VehicleBasedFeeStrategy();
            activeTickets = new Dictionary<string, ParkingTicket>();
        }

        public static ParkingLot GetInstance()
        {
            if(instance == null)
            {
                lock (instanceLock)
                {
                    if( instance == null )
                    {
                        instance = new ParkingLot();
                    }
                }
            }

            return instance;
        }
        

        public bool ParkVehicle(Vehicle vehicle)
        {
            lock (mainLock)
            {
                ParkingSpot? spot = parkingStrategy.FindAvailableSpot(parkingFloors, vehicle);

                if(spot != null)
                {
                    spot.ParkVehicle(vehicle);
                    ParkingTicket ticket = new ParkingTicket(spot, vehicle);
                    activeTickets.Add(vehicle.GetLicense(), ticket);
                    return true;
                }
 
                return false;
            }
        }

        public double? UnParkVehicle(string licenseNumber)
        {
            lock (mainLock)
            {
                foreach (ParkingFloor floor in parkingFloors)
                {
                    foreach (ParkingSpot spot in floor.parkingSpots)
                    {
                        if (spot.IsAvailable() == false && spot.vehicle.GetLicense() == licenseNumber)
                        {
                            if(!activeTickets.TryGetValue(licenseNumber, out ParkingTicket? ticket))
                            {
                                Console.WriteLine("Ticket not found!");
                                return null;
                            }

                            ticket.SetExitTime();
                            double fee = feeStrategy.CalculateFee(ticket);
                            spot.UnParkVehicle();

                            return fee;
                        }
                    }
                }

                return null;
            }
        }

        public void AddFloor(ParkingFloor floor)
        {
            parkingFloors.Add(floor);
        }

        public void SetParkingStrategy(IParkingStrategy strategy)
        {
            parkingStrategy = strategy;
        }
    }
}
