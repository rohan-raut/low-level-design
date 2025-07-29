﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    internal interface ITransportationMode
    {
        int GetETA();

        void GetDirection();
    }
}
