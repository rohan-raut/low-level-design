using ParkingLot.Enums;
using ParkingLot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Strategies.Fee
{
    internal class VehicleBasedFeeStrategy : IFeeStrategy
    {
        private Dictionary<VehicleSize, double> prices;

        public VehicleBasedFeeStrategy()
        {
            prices = new Dictionary<VehicleSize, double>()
            {
                {VehicleSize.SMALL, 5.00 },
                {VehicleSize.MEDIUM, 10.00 },
                {VehicleSize.LARGE, 15.00 },
            };
        }

        public double CalculateFee(ParkingTicket ticket)
        {
            prices.TryGetValue(ticket.vehicle.GetVehicleSize(), out double fee);

            return fee;
        }
    }
}
