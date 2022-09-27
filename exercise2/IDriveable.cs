﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    internal interface IDriveable
    {
        string Name { get; set; }

        int VehicleSpeed { get; set; }

        int RemainingFuel { get; set; }

        void StartEngine();

        void StopEngine();

        void Gas();

        void Break();

        void TurnLeft();

        void TurnRight();

    }
}
