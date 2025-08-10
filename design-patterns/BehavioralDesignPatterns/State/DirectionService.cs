using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class DirectionService
    {
        private ITransportationMode transportationMode;

        public DirectionService(ITransportationMode transportationMode)
        {
            this.transportationMode = transportationMode;
        }

        public void SetTransportationMode(ITransportationMode transportationMode)
        {
            this.transportationMode = transportationMode;
        }

        public int GetETA()
        {
            Console.WriteLine("ETA: " + transportationMode.GetETA());
            return transportationMode.GetETA();
        }

        public void GetDirection()
        {
            transportationMode.GetDirection();
        }
    }
}
