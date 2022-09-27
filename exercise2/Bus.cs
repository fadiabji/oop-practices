using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;

namespace exercise2
{
    internal class Bus : IDriveable
    {
        public string Name { get; set; }
        public int VehicleSpeed { get; set; }
        public int RemainingFuel { get; set; }

        public void Break()
        {
            Console.WriteLine($"{this.Name} press beak!");
        }

        public void Gas()
        {
            Console.WriteLine($"{this.Name} press gas!");
        }

        public void StartEngine()
        {
            Console.WriteLine($"{this.Name} started engine!");
        }

        public void StopEngine()
        {
            Console.WriteLine($"{this.Name} Stopped Engine!");
        }

        public void TurnLeft()
        {
            Console.WriteLine($"{this.Name} turned left!");

        }

        public void TurnRight()
        {
            Console.WriteLine($"{this.Name} turned right!");
        }

        public static void TestDrive(IDriveable drivable)
        {
            drivable.TurnRight();
            drivable.Break();
            drivable.StartEngine();
            drivable.StopEngine();
            drivable.TurnLeft();
            drivable.Gas();
        }
    }
}
