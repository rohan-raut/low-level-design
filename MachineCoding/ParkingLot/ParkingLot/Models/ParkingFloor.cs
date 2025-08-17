using ParkingLot.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Models
{
    internal class ParkingFloor
    {
        private string parkingFloorId;
        private int floorNo;
        public List<ParkingSpot> parkingSpots;

        public ParkingFloor(string parkingFloorId, int floorNo)
        {
            this.parkingFloorId = parkingFloorId;
            this.floorNo = floorNo;
            parkingSpots = new List<ParkingSpot>();
        }


        public void AddSpot(ParkingSpot spot)
        {
            parkingSpots.Add(spot);
        }

        public void DisplayAvailability()
        {
            Console.WriteLine("Availability for Floor: " +  parkingFloorId);
            foreach(ParkingSpot spot in parkingSpots)
            {
                if (spot.IsAvailable())
                {
                    Console.WriteLine(spot.ToString());
                }
            }
        }

        public ParkingSpot? FindAvailability(Vehicle vehicle)
        {
            foreach(ParkingSpot spot in parkingSpots)
            {
                if (spot.IsAvailable() == true && spot.CanFit(vehicle) == true)
                {
                    return spot;
                }
            }

            return null;
        }
    }
}
