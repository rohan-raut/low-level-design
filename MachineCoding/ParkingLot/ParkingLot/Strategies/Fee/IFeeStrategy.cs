using ParkingLot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Strategies.Fee
{
    internal interface IFeeStrategy
    {
        double CalculateFee(ParkingTicket ticket);
    }
}
