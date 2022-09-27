using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;

namespace exercise3
{
    internal class Bus : EngineVehicle
    {
        public override int RemainingFuel
        {
            get
            {
                return base.RemainingFuel ;
            }
            set
            {
                base.RemainingFuel = value;
            }
        }

        public override int speed
        {
            get
            {
                return base.speed;
            }
            set
            {
                if(value > 120) { value = 120; }
                base.speed = value;
            }
        }
        public string Name { get; set; }
        public int VehicleSpeed { get; set; }

        public Bus()
        {
            RemainingFuel = 150;
            //Change this value to 115 to check the bus speed specification!
            speed = 0;
        }

        public void Break()
        {
            Console.WriteLine($"{this.Name} press beak!");
            this.speed -= 5;
            Console.WriteLine($"{this.speed} km/h The vehicle speed!");
        }

        public void Gas()
        {
            Console.WriteLine($"{this.Name} press gas!");
            this.speed += 5;
            this.RemainingFuel -= 15;
            Console.WriteLine($"{this.speed} km/h The vehicle speed!");
            Console.WriteLine($"{this.RemainingFuel} Liters is remainingFuel!");
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
    }
}
