using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Models
{
    internal class ParkingTicket
    {
        private DateTime entryTime;
        private DateTime exitTime;
        private ParkingSpot parkingSpot;
        public Vehicle vehicle;

        public ParkingTicket(ParkingSpot parkingSpot, Vehicle vehicle)
        {
            this.entryTime = DateTime.Now;
            this.parkingSpot = parkingSpot;
            this.vehicle = vehicle;
        }

        public void SetExitTime()
        {
            exitTime = DateTime.Now;
        }
    }
}
